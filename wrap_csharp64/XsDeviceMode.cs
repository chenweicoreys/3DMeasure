/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XDA {

using System;
using System.Runtime.InteropServices;

public class XsDeviceMode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceMode(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsDeviceMode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceMode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDeviceMode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsDeviceMode(int rate) : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_0(rate), true) {
  }

  public XsDeviceMode() : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_1(), true) {
  }

  public XsDeviceMode(ushort sampleperiod, ushort skipfactor) : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_2(sampleperiod, skipfactor), true) {
  }

  public XsDeviceMode(XsDeviceMode other) : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_3(XsDeviceMode.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsDeviceMode(XsDeviceModeR other) : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_4(XsDeviceModeR.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsDeviceMode(XsDeviceModePS other) : this(xsensdeviceapiPINVOKE.new_XsDeviceMode__SWIG_5(XsDeviceModePS.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setModeFlag(XsOutputMode flag, bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setModeFlag__SWIG_0(swigCPtr, (int)flag, enabled);
  }

  public void setModeFlag(XsOutputMode flag) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setModeFlag__SWIG_1(swigCPtr, (int)flag);
  }

  public bool isModeFlagEnabled(XsOutputMode flag) {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isModeFlagEnabled(swigCPtr, (int)flag);
    return ret;
  }

  public void setSettingsFlag(XsOutputSettings flag, bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setSettingsFlag__SWIG_0(swigCPtr, (int)flag, enabled);
  }

  public void setSettingsFlag(XsOutputSettings flag) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setSettingsFlag__SWIG_1(swigCPtr, (int)flag);
  }

  public bool isSettingsFlagEnabled(XsOutputSettings flag) {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isSettingsFlagEnabled(swigCPtr, (int)flag);
    return ret;
  }

  public double sampleRate() {
    double ret = xsensdeviceapiPINVOKE.XsDeviceMode_sampleRate(swigCPtr);
    return ret;
  }

  public ushort updateRate() {
    ushort ret = xsensdeviceapiPINVOKE.XsDeviceMode_updateRate(swigCPtr);
    return ret;
  }

  public void setUpdateRate(int rate) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setUpdateRate(swigCPtr, rate);
  }

  public void setPeriodAndSkipFactor(int sampleperiod, int skipfactor) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setPeriodAndSkipFactor(swigCPtr, sampleperiod, skipfactor);
  }

  public int period() {
    int ret = xsensdeviceapiPINVOKE.XsDeviceMode_period(swigCPtr);
    return ret;
  }

  public int skipFactor() {
    int ret = xsensdeviceapiPINVOKE.XsDeviceMode_skipFactor(swigCPtr);
    return ret;
  }

  public void setOrientationMode(XsOrientationMode mode) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setOrientationMode(swigCPtr, (int)mode);
  }

  public XsOrientationMode orientationMode() {
    XsOrientationMode ret = (XsOrientationMode)xsensdeviceapiPINVOKE.XsDeviceMode_orientationMode(swigCPtr);
    return ret;
  }

  public void setDataFormat(XsFloatFormat ff) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setDataFormat(swigCPtr, (int)ff);
  }

  public XsFloatFormat dataFormat() {
    XsFloatFormat ret = (XsFloatFormat)xsensdeviceapiPINVOKE.XsDeviceMode_dataFormat(swigCPtr);
    return ret;
  }

  public void setCalibratedDataMode(XsCalibratedDataMode mode) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setCalibratedDataMode(swigCPtr, (int)mode);
  }

  public XsCalibratedDataMode calibratedDataMode() {
    XsCalibratedDataMode ret = (XsCalibratedDataMode)xsensdeviceapiPINVOKE.XsDeviceMode_calibratedDataMode(swigCPtr);
    return ret;
  }

  public void setAnalogInChannelEnabled(int channelIndex, bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setAnalogInChannelEnabled(swigCPtr, channelIndex, enabled);
  }

  public bool isAnalogInChannelEnabled(int channelIndex) {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isAnalogInChannelEnabled(swigCPtr, channelIndex);
    return ret;
  }

  public void setCoordinateSystem(XsCoordinateSystem coordinatesystem) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setCoordinateSystem(swigCPtr, (int)coordinatesystem);
  }

  public XsCoordinateSystem coordinateSystem() {
    XsCoordinateSystem ret = (XsCoordinateSystem)xsensdeviceapiPINVOKE.XsDeviceMode_coordinateSystem(swigCPtr);
    return ret;
  }

  public void setStatusOutputEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setStatusOutputEnabled(swigCPtr, enabled);
  }

  public bool isStatusOutputEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isStatusOutputEnabled(swigCPtr);
    return ret;
  }

  public void setTemperatureOutputEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setTemperatureOutputEnabled(swigCPtr, enabled);
  }

  public bool isTemperatureOutputEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isTemperatureOutputEnabled(swigCPtr);
    return ret;
  }

  public void setPositionDataEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setPositionDataEnabled(swigCPtr, enabled);
  }

  public bool isPositionDataEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isPositionDataEnabled(swigCPtr);
    return ret;
  }

  public void setVelocityDataEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setVelocityDataEnabled(swigCPtr, enabled);
  }

  public bool isVelocityDataEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isVelocityDataEnabled(swigCPtr);
    return ret;
  }

  public void setGpsPvtDataEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setGpsPvtDataEnabled(swigCPtr, enabled);
  }

  public bool isGpsPvtDataEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isGpsPvtDataEnabled(swigCPtr);
    return ret;
  }

  public void setRawDataOutputEnabled(bool enabled) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setRawDataOutputEnabled(swigCPtr, enabled);
  }

  public bool isRawDataOutputEnabled() {
    bool ret = xsensdeviceapiPINVOKE.XsDeviceMode_isRawDataOutputEnabled(swigCPtr);
    return ret;
  }

  public XsDeviceModeR toXsDeviceMode() {
    XsDeviceModeR ret = new XsDeviceModeR(xsensdeviceapiPINVOKE.XsDeviceMode_toXsDeviceMode(swigCPtr), true);
    return ret;
  }

  public XsDeviceModePS toXsDeviceMode2() {
    XsDeviceModePS ret = new XsDeviceModePS(xsensdeviceapiPINVOKE.XsDeviceMode_toXsDeviceMode2(swigCPtr), true);
    return ret;
  }

  public XsOutputMode outputMode() {
    XsOutputMode ret = (XsOutputMode)xsensdeviceapiPINVOKE.XsDeviceMode_outputMode(swigCPtr);
    return ret;
  }

  public void setOutputMode(XsOutputMode mode) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setOutputMode(swigCPtr, (int)mode);
  }

  public XsOutputSettings outputSettings() {
    XsOutputSettings ret = (XsOutputSettings)xsensdeviceapiPINVOKE.XsDeviceMode_outputSettings(swigCPtr);
    return ret;
  }

  public void setOutputSettings(XsOutputSettings settings) {
    xsensdeviceapiPINVOKE.XsDeviceMode_setOutputSettings(swigCPtr, (int)settings);
  }

}

}
