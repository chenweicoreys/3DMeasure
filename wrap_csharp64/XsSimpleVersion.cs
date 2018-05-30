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

public class XsSimpleVersion : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSimpleVersion(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsSimpleVersion obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSimpleVersion() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsSimpleVersion(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsSimpleVersion(int vmaj, int vmin, int vrev) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_0(vmaj, vmin, vrev), true) {
  }

  public XsSimpleVersion(int vmaj, int vmin) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_1(vmaj, vmin), true) {
  }

  public XsSimpleVersion(int vmaj) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_2(vmaj), true) {
  }

  public XsSimpleVersion() : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_3(), true) {
  }

  public XsSimpleVersion(SWIGTYPE_p_XsSimpleVersion other) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_4(SWIGTYPE_p_XsSimpleVersion.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsSimpleVersion(SWIGTYPE_p_XsVersion other) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_5(SWIGTYPE_p_XsVersion.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsSimpleVersion(XsString vString) : this(xsensdeviceapiPINVOKE.new_XsSimpleVersion__SWIG_6(XsString.getCPtr(vString)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsSimpleVersion_empty(swigCPtr);
    return ret;
  }

  public XsString toXsString() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsSimpleVersion_toXsString(swigCPtr), true);
    return ret;
  }

  public int major() {
    int ret = xsensdeviceapiPINVOKE.XsSimpleVersion_major(swigCPtr);
    return ret;
  }

  public int minor() {
    int ret = xsensdeviceapiPINVOKE.XsSimpleVersion_minor(swigCPtr);
    return ret;
  }

  public int revision() {
    int ret = xsensdeviceapiPINVOKE.XsSimpleVersion_revision(swigCPtr);
    return ret;
  }

}

}
