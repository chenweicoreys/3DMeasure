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

public class XsDataFormat : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDataFormat(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsDataFormat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDataFormat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDataFormat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsOutputMode m_outputMode {
    set {
      xsensdeviceapiPINVOKE.XsDataFormat_m_outputMode_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputMode ret = (XsOutputMode)xsensdeviceapiPINVOKE.XsDataFormat_m_outputMode_get(swigCPtr);
      return ret;
    } 
  }

  public XsOutputSettings m_outputSettings {
    set {
      xsensdeviceapiPINVOKE.XsDataFormat_m_outputSettings_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputSettings ret = (XsOutputSettings)xsensdeviceapiPINVOKE.XsDataFormat_m_outputSettings_get(swigCPtr);
      return ret;
    } 
  }

  public XsDataFormat(XsOutputMode mode, XsOutputSettings settings) : this(xsensdeviceapiPINVOKE.new_XsDataFormat__SWIG_0((int)mode, (int)settings), true) {
  }

  public XsDataFormat(XsOutputMode mode) : this(xsensdeviceapiPINVOKE.new_XsDataFormat__SWIG_1((int)mode), true) {
  }

  public XsDataFormat() : this(xsensdeviceapiPINVOKE.new_XsDataFormat__SWIG_2(), true) {
  }

  public XsDataFormat(XsDataFormat other) : this(xsensdeviceapiPINVOKE.new_XsDataFormat__SWIG_3(XsDataFormat.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
