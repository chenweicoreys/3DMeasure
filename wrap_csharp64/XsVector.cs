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

public class XsVector : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsVector(uint sz, SWIGTYPE_p_double src) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_0(sz, SWIGTYPE_p_double.getCPtr(src)), true) {
  }

  public XsVector(uint sz) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_1(sz), true) {
  }

  public XsVector() : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_2(), true) {
  }

  public XsVector(XsVector other) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_3(XsVector.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVector(SWIGTYPE_p_double arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_4(SWIGTYPE_p_double.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsVector(SWIGTYPE_p_double arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_5(SWIGTYPE_p_double.getCPtr(arg0), sz), true) {
  }

  public XsVector(XsVector other, SWIGTYPE_p_double arg1, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_6(XsVector.getCPtr(other), SWIGTYPE_p_double.getCPtr(arg1), sz, (int)flags), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVector(XsVector other, SWIGTYPE_p_double arg1, uint sz) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_7(XsVector.getCPtr(other), SWIGTYPE_p_double.getCPtr(arg1), sz), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsVector(XsQuaternion quat, double deltaT) : this(xsensdeviceapiPINVOKE.new_XsVector__SWIG_8(XsQuaternion.getCPtr(quat), deltaT), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void assign(uint sz, SWIGTYPE_p_double src) {
    xsensdeviceapiPINVOKE.XsVector_assign(swigCPtr, sz, SWIGTYPE_p_double.getCPtr(src));
  }

  public void setSize(uint sz) {
    xsensdeviceapiPINVOKE.XsVector_setSize(swigCPtr, sz);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsVector_size(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_double data() {
    IntPtr cPtr = xsensdeviceapiPINVOKE.XsVector_data(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_double at(uint index) {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(xsensdeviceapiPINVOKE.XsVector_at__SWIG_0(swigCPtr, index), false);
    return ret;
  }

  public double value(uint index) {
    double ret = xsensdeviceapiPINVOKE.XsVector_value(swigCPtr, index);
    return ret;
  }

  public void setValue(uint index, double val) {
    xsensdeviceapiPINVOKE.XsVector_setValue(swigCPtr, index, val);
  }

  public double dotProduct(XsVector v) {
    double ret = xsensdeviceapiPINVOKE.XsVector_dotProduct(swigCPtr, XsVector.getCPtr(v));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double cartesianLength() {
    double ret = xsensdeviceapiPINVOKE.XsVector_cartesianLength(swigCPtr);
    return ret;
  }

  public void setZero() {
    xsensdeviceapiPINVOKE.XsVector_setZero(swigCPtr);
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsVector_empty(swigCPtr);
    return ret;
  }

  public XsVector angularVelocityFromQuaternion(XsQuaternion quat, double deltaT) {
    XsVector ret = new XsVector(xsensdeviceapiPINVOKE.XsVector_angularVelocityFromQuaternion(swigCPtr, XsQuaternion.getCPtr(quat), deltaT), false);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_double_t toVector() {
    SWIGTYPE_p_std__vectorT_double_t ret = new SWIGTYPE_p_std__vectorT_double_t(xsensdeviceapiPINVOKE.XsVector_toVector(swigCPtr), true);
    return ret;
  }

  public void zero() {
    xsensdeviceapiPINVOKE.XsVector_zero(swigCPtr);
  }

  public void fill(double value) {
    xsensdeviceapiPINVOKE.XsVector_fill(swigCPtr, value);
  }

  public void swap(XsVector b) {
    xsensdeviceapiPINVOKE.XsVector_swap(swigCPtr, XsVector.getCPtr(b));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
