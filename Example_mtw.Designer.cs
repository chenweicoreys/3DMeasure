﻿/* Copyright (c) Xsens Technologies B.V., 2006-2013. All rights reserved.
 
      This source code is provided under the MT SDK Software License Agreement 
and is intended for use only by Xsens Technologies BV and
       those that have explicit written permission to use it from
       Xsens Technologies BV.
 
      THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
       KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
       IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
       PARTICULAR PURPOSE.
 */

namespace MTwExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.cbxStations = new System.Windows.Forms.ComboBox();
            this.lblDeviceCount = new System.Windows.Forms.Label();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(17, 14);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(123, 27);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(16, 140);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(123, 27);
            this.btnEnable.TabIndex = 3;
            this.btnEnable.Text = "Enable Radio";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(21, 95);
            this.lblChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(71, 15);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel:";
            // 
            // cbxStations
            // 
            this.cbxStations.FormattingEnabled = true;
            this.cbxStations.Location = new System.Drawing.Point(17, 59);
            this.cbxStations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxStations.Name = "cbxStations";
            this.cbxStations.Size = new System.Drawing.Size(385, 23);
            this.cbxStations.TabIndex = 5;
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Location = new System.Drawing.Point(160, 189);
            this.lblDeviceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(151, 15);
            this.lblDeviceCount.TabIndex = 6;
            this.lblDeviceCount.Text = "MTw\'s Connected: 0";
            // 
            // btnMeasure
            // 
            this.btnMeasure.Enabled = false;
            this.btnMeasure.Location = new System.Drawing.Point(16, 183);
            this.btnMeasure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(123, 27);
            this.btnMeasure.TabIndex = 8;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(17, 271);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 27);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(444, 14);
            this.rtbSteps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.ReadOnly = true;
            this.rtbSteps.Size = new System.Drawing.Size(433, 268);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            // 
            // rtbData
            // 
            this.rtbData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbData.Location = new System.Drawing.Point(16, 315);
            this.rtbData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(861, 235);
            this.rtbData.TabIndex = 11;
            this.rtbData.Text = "";
            this.rtbData.TextChanged += new System.EventHandler(this.rtbData_TextChanged);
            // 
            // cbxChannel
            // 
            this.cbxChannel.DisplayMember = "19";
            this.cbxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel.FormattingEnabled = true;
            this.cbxChannel.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbxChannel.Location = new System.Drawing.Point(95, 89);
            this.cbxChannel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(96, 23);
            this.cbxChannel.TabIndex = 12;
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(16, 227);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(123, 27);
            this.btnRecord.TabIndex = 13;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(164, 231);
            this.textBoxFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(113, 25);
            this.textBoxFilename.TabIndex = 21;
            this.textBoxFilename.Text = "logfile.mtb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 564);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cbxChannel);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.lblDeviceCount);
            this.Controls.Add(this.cbxStations);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnScan);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MTw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ComboBox cbxStations;
		private System.Windows.Forms.Label lblDeviceCount;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.RichTextBox rtbData;
		private System.Windows.Forms.ComboBox cbxChannel;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.TextBox textBoxFilename;
    }
}

