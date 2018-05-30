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

public class XsDeviceModePS : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceModePS(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsDeviceModePS obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceModePS() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDeviceModePS(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsOutputMode m_outputMode {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModePS_m_outputMode_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputMode ret = (XsOutputMode)xsensdeviceapiPINVOKE.XsDeviceModePS_m_outputMode_get(swigCPtr);
      return ret;
    } 
  }

  public XsOutputSettings m_outputSettings {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModePS_m_outputSettings_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputSettings ret = (XsOutputSettings)xsensdeviceapiPINVOKE.XsDeviceModePS_m_outputSettings_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_period {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModePS_m_period_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsDeviceModePS_m_period_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_skip {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModePS_m_skip_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsDeviceModePS_m_skip_get(swigCPtr);
      return ret;
    } 
  }

  public XsDeviceModePS(XsOutputMode mode, XsOutputSettings settings, ushort period, ushort skip) : this(xsensdeviceapiPINVOKE.new_XsDeviceModePS__SWIG_0((int)mode, (int)settings, period, skip), true) {
  }

  public XsDeviceModePS(XsOutputMode mode, XsOutputSettings settings, ushort period) : this(xsensdeviceapiPINVOKE.new_XsDeviceModePS__SWIG_1((int)mode, (int)settings, period), true) {
  }

  public XsDeviceModePS(XsOutputMode mode, XsOutputSettings settings) : this(xsensdeviceapiPINVOKE.new_XsDeviceModePS__SWIG_2((int)mode, (int)settings), true) {
  }

  public XsDeviceModePS(XsOutputMode mode) : this(xsensdeviceapiPINVOKE.new_XsDeviceModePS__SWIG_3((int)mode), true) {
  }

  public XsDeviceModePS() : this(xsensdeviceapiPINVOKE.new_XsDeviceModePS__SWIG_4(), true) {
  }

  public int updateRate() {
    int ret = xsensdeviceapiPINVOKE.XsDeviceModePS_updateRate(swigCPtr);
    return ret;
  }

  public void setUpdateRate(int rate) {
    xsensdeviceapiPINVOKE.XsDeviceModePS_setUpdateRate(swigCPtr, rate);
  }

}

}
