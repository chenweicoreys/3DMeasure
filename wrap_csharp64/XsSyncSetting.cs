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

public class XsSyncSetting : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSyncSetting(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsSyncSetting obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSyncSetting() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsSyncSetting(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsSyncLine m_line {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_line_set(swigCPtr, (int)value);
    } 
    get {
      XsSyncLine ret = (XsSyncLine)xsensdeviceapiPINVOKE.XsSyncSetting_m_line_get(swigCPtr);
      return ret;
    } 
  }

  public XsSyncFunction m_function {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_function_set(swigCPtr, (int)value);
    } 
    get {
      XsSyncFunction ret = (XsSyncFunction)xsensdeviceapiPINVOKE.XsSyncSetting_m_function_get(swigCPtr);
      return ret;
    } 
  }

  public XsSyncPolarity m_polarity {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_polarity_set(swigCPtr, (int)value);
    } 
    get {
      XsSyncPolarity ret = (XsSyncPolarity)xsensdeviceapiPINVOKE.XsSyncSetting_m_polarity_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_pulseWidth {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_pulseWidth_set(swigCPtr, value);
    } 
    get {
      uint ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_pulseWidth_get(swigCPtr);
      return ret;
    } 
  }

  public int m_offset {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_offset_set(swigCPtr, value);
    } 
    get {
      int ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_offset_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_skipFirst {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_skipFirst_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_skipFirst_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_skipFactor {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_skipFactor_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_skipFactor_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_clockPeriod {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_clockPeriod_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_clockPeriod_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_triggerOnce {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_triggerOnce_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_triggerOnce_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_padding {
    set {
      xsensdeviceapiPINVOKE.XsSyncSetting_m_padding_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsSyncSetting_m_padding_get(swigCPtr);
      return ret;
    } 
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth, int offset, ushort skipFirst, ushort skipFactor, ushort clockPeriod, byte triggerOnce) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_0((int)line, (int)function, (int)polarity, pulseWidth, offset, skipFirst, skipFactor, clockPeriod, triggerOnce), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth, int offset, ushort skipFirst, ushort skipFactor, ushort clockPeriod) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_1((int)line, (int)function, (int)polarity, pulseWidth, offset, skipFirst, skipFactor, clockPeriod), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth, int offset, ushort skipFirst, ushort skipFactor) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_2((int)line, (int)function, (int)polarity, pulseWidth, offset, skipFirst, skipFactor), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth, int offset, ushort skipFirst) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_3((int)line, (int)function, (int)polarity, pulseWidth, offset, skipFirst), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth, int offset) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_4((int)line, (int)function, (int)polarity, pulseWidth, offset), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity, uint pulseWidth) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_5((int)line, (int)function, (int)polarity, pulseWidth), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function, XsSyncPolarity polarity) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_6((int)line, (int)function, (int)polarity), true) {
  }

  public XsSyncSetting(XsSyncLine line, XsSyncFunction function) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_7((int)line, (int)function), true) {
  }

  public XsSyncSetting(XsSyncLine line) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_8((int)line), true) {
  }

  public XsSyncSetting() : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_9(), true) {
  }

  public XsSyncSetting(XsSyncSetting other) : this(xsensdeviceapiPINVOKE.new_XsSyncSetting__SWIG_10(XsSyncSetting.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isInput() {
    bool ret = xsensdeviceapiPINVOKE.XsSyncSetting_isInput(swigCPtr);
    return ret;
  }

  public bool isOutput() {
    bool ret = xsensdeviceapiPINVOKE.XsSyncSetting_isOutput(swigCPtr);
    return ret;
  }

  public void swap(XsSyncSetting other) {
    xsensdeviceapiPINVOKE.XsSyncSetting_swap(swigCPtr, XsSyncSetting.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
