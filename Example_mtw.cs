﻿

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xsens;
using XDA;

namespace MTwExample
{
    public partial class Form1 : Form
    {
        private MyXda _xda;
		private XsDevice _measuringDevice = null;
		private Dictionary<XsDevice, MyMtCallback> _measuringMts = new Dictionary<XsDevice, MyMtCallback>();
		private Dictionary<uint, ConnectedMtData> _connectedMtwData = new Dictionary<uint, ConnectedMtData>();

        public Form1()
        {
            InitializeComponent();
            _xda = new MyXda();
			cbxChannel.SelectedIndex = 0;
            step(1);
        }

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Enabled = false;

			if (_measuringDevice != null)
				_measuringDevice.clearCallbackHandlers();
			
			_measuringMts.Clear();

			_xda.Dispose();
			_xda = null;
		}

        private void btnScan_Click(object sender, EventArgs e)
        {
            cbxStations.Items.Clear();
			_xda.scanPorts();
			if (_xda._DetectedDevices.Count > 0)
			{
				foreach (XsPortInfo portInfo in _xda._DetectedDevices)
				{
					if (portInfo.deviceId().isWirelessMaster())
					{
						_xda.openPort(portInfo);
						MasterInfo ai = new MasterInfo(portInfo.deviceId());
						ai.ComPort = portInfo.portName();
						ai.BaudRate = portInfo.baudrate();
						cbxStations.Items.Add(ai);
						break;
					}
				}

				if (cbxStations.Items.Count > 0)
				{
					cbxStations.SelectedIndex = 0;
					btnEnable.Enabled = true;
					step(2);
				}
				else
				{
					step(3);
				}
			}
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
			XsDevice device = _xda.getDevice(((MasterInfo)cbxStations.SelectedItem).DeviceId);
			if (device.isRadioEnabled())
				device.disableRadio();
            if (device.enableRadio(Convert.ToInt32(cbxChannel.Text)))
            {
                btnScan.Enabled = false;
                btnEnable.Enabled = false;
                btnMeasure.Enabled = true;
                step(4);
            }
            else
            {
                step(6);
                btnScan.Enabled = true;
                btnEnable.Enabled = false;
            }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            step(9);
			_connectedMtwData.Clear();
			_measuringDevice = _xda.getDevice(((MasterInfo)cbxStations.SelectedItem).DeviceId);
			_measuringDevice.gotoMeasurement();
			XsDevicePtrArray deviceIds = _measuringDevice.children();
			for (uint i = 0; i < deviceIds.size(); i++)
			{
				XsDevice mtw = new XsDevice(deviceIds.at(i));
				MyMtCallback callback = new MyMtCallback();

				ConnectedMtData mtwData = new ConnectedMtData();
				_connectedMtwData.Add(mtw.deviceId().toInt(), mtwData);

				// connect signals
				callback.DataAvailable += new EventHandler<DataAvailableArgs>(_callbackHandler_DataAvailable);

				mtw.addCallbackHandler(callback);
				_measuringMts.Add(mtw, callback);
			}
			lblDeviceCount.Text = string.Format("MTw's Connected: {0}", deviceIds.size());
            btnMeasure.Enabled = false;
			btnRecord.Enabled = true;
            btnStop.Enabled = true;
            timer1.Interval = 20;
            timer1.Enabled = true;
        }

		private void btnRecord_Click(object sender, EventArgs e)
		{
			_measuringDevice.createLogFile(new XsString(textBoxFilename.Text));
			_measuringDevice.startRecording();
			btnRecord.Enabled = false;
		}

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            timer1.Enabled = false;

			if (_measuringDevice.isRecording())
				_measuringDevice.stopRecording();
			_measuringDevice.gotoConfig();
			_measuringDevice.disableRadio();
			_measuringDevice.clearCallbackHandlers();

            btnScan.Enabled = true;

            if (cbxStations.Items.Count > 0)
            {
                cbxStations.SelectedIndex = 0;
                btnEnable.Enabled = true;
                step(2);
            }
            else
            {
                step(1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			string text = "";
            //in 在数组_connectedMteData 数组中遍历
		    foreach (KeyValuePair<uint, ConnectedMtData> data in _connectedMtwData)
            {
				if (data.Value._orientation != null)
				{
					text += string.Format("{3:X8} {0,-5:f2}, {1,-5:f2}, {2,-5:f2} [°]\n",
										   data.Value._orientation.x(),
										   data.Value._orientation.y(),
										   data.Value._orientation.z(), data.Key);
				}
            }
			rtbData.Text = text;
        }

		void _callbackHandler_DataAvailable(object sender, DataAvailableArgs e)
		{
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { _callbackHandler_DataAvailable(sender, e); }));
			}
			else
			{
				//Getting Euler angles.
				XsEuler oriEuler = e.Packet.orientationEuler();

				_connectedMtwData[e.Device.deviceId().toInt()]._orientation = oriEuler;
			}
		}

        /// <summary>
        /// Some step by step info
        /// </summary>
        /// <param name="stepNumber"></param>
        private void step(int stepNumber)
        {
            switch (stepNumber)
            {
                case 1:
                    rtbSteps.Text = "Connect the Awinda Station, dock the MTWs and click 'Scan'.";
                    break;
                case 2:
                    rtbSteps.Text = "Select a station from the combobox, select a channel and click 'Enable Radio'.";
                    break;
                case 3:
                    rtbSteps.Text = "No station was found, make sure the drivers were installed correctly.";
                    break;
                case 4:
                    rtbSteps.Text = "Undock the MTws from the station and wait for them to connect to the station. This is indicated by the MTw LEDs blinking in sync with the CONN LED on the station.\n\n" +
                                    "Then click 'Measure' and wait a bit.";
                    break;
                case 6:
                    rtbSteps.Text = "There was an unexpected failure enabling the station.";
                    break;
                case 8:
                    rtbSteps.Text = "There was an unexpected failure going to the operational mode.";
                    break;
                case 9:
                    rtbSteps.Text = "Enjoy the data... click 'Stop' when no further joy can be obtained from looking at the data.\nClick 'Record' when you want to feel the same joy again at a later moment";
                    break;
                default:
                    rtbSteps.Text = "No station was found, make sure the drivers were installed correctly.";
                    break;
            }
        }

        private void rtbData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
