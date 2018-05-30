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

public class XsException : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsException(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsException obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsException() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsException(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsException(XsException e) : this(xsensdeviceapiPINVOKE.new_XsException__SWIG_0(XsException.getCPtr(e)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsException(XsResultValue err, XsString description, bool prefix) : this(xsensdeviceapiPINVOKE.new_XsException__SWIG_1((int)err, XsString.getCPtr(description), prefix), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsException(XsResultValue err, XsString description) : this(xsensdeviceapiPINVOKE.new_XsException__SWIG_2((int)err, XsString.getCPtr(description)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsException(XsString description) : this(xsensdeviceapiPINVOKE.new_XsException__SWIG_3(XsString.getCPtr(description)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsResultValue code() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsException_code(swigCPtr);
    return ret;
  }

  public string what() {
    string ret = xsensdeviceapiPINVOKE.XsException_what(swigCPtr);
    return ret;
  }

  public XsString text() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsException_text(swigCPtr), false);
    return ret;
  }

}

}
