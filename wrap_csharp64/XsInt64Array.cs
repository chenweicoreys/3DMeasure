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

public class XsInt64Array : XsInt64ArrayImpl {
  private HandleRef swigCPtr;

  internal XsInt64Array(IntPtr cPtr, bool cMemoryOwn) : base(xsensdeviceapiPINVOKE.XsInt64Array_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsInt64Array obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsInt64Array() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsInt64Array(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public XsInt64Array(uint sz, SWIGTYPE_p_long_long src) : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_0(sz, SWIGTYPE_p_long_long.getCPtr(src)), true) {
  }

  public XsInt64Array(uint sz) : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_1(sz), true) {
  }

  public XsInt64Array() : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_2(), true) {
  }

  public XsInt64Array(XsInt64Array other) : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_3(XsInt64Array.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsInt64Array(SWIGTYPE_p_long_long arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_4(SWIGTYPE_p_long_long.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsInt64Array(SWIGTYPE_p_long_long arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsInt64Array__SWIG_5(SWIGTYPE_p_long_long.getCPtr(arg0), sz), true) {
  }

}

}
