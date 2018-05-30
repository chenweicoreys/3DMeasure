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

public class XsByteArrayImpl : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsByteArrayImpl(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XsByteArrayImpl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsByteArrayImpl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsByteArrayImpl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XsByteArrayImpl(uint count, SWIGTYPE_p_unsigned_char src) : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_0(count, SWIGTYPE_p_unsigned_char.getCPtr(src)), true) {
  }

  public XsByteArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_1(count), true) {
  }

  public XsByteArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_2(), true) {
  }

  public XsByteArrayImpl(XsByteArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_3(XsByteArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsByteArrayImpl(SWIGTYPE_p_unsigned_char arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_4(SWIGTYPE_p_unsigned_char.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsByteArrayImpl(SWIGTYPE_p_unsigned_char arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsByteArrayImpl__SWIG_5(SWIGTYPE_p_unsigned_char.getCPtr(arg0), sz), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsByteArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsByteArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public byte at(uint index) {
    byte ret = xsensdeviceapiPINVOKE.XsByteArrayImpl_at__SWIG_0(swigCPtr, index);
    return ret;
  }

  public void insert(byte item, uint index) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_insert__SWIG_0(swigCPtr, item, index);
  }

  public void insert(SWIGTYPE_p_unsigned_char items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_insert__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(items), index, count);
  }

  public void push_back(byte item) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_push_back(swigCPtr, item);
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(byte item) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_push_front(swigCPtr, item);
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsByteArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, SWIGTYPE_p_unsigned_char src) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_assign(swigCPtr, count, SWIGTYPE_p_unsigned_char.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsByteArrayImpl other) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_append(swigCPtr, XsByteArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsByteArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsByteArrayImpl other) {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_swap(swigCPtr, XsByteArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int find(byte needle) {
    int ret = xsensdeviceapiPINVOKE.XsByteArrayImpl_find(swigCPtr, needle);
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_removeDuplicates(swigCPtr);
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsByteArrayImpl_sort(swigCPtr);
  }

}

}
