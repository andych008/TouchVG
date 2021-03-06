/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgShapeIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgShapeIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgShapeIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgShapeIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgShapeIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MgShapeIterator(MgShapes shapes) : this(touchvgPINVOKE.new_MgShapeIterator(MgShapes.getCPtr(shapes)), true) {
  }

  public bool hasNext() {
    bool ret = touchvgPINVOKE.MgShapeIterator_hasNext(swigCPtr);
    return ret;
  }

  public MgShape getNext() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeIterator_getNext(swigCPtr);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

}

}
