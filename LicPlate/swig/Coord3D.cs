/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Coord3D : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Coord3D(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Coord3D obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Coord3D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_Coord3D(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public Coord3D(double xx, double yy, double zz) : this(VisionLabPINVOKE.new_Coord3D__SWIG_0(xx, yy, zz), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Coord3D(double xx, double yy) : this(VisionLabPINVOKE.new_Coord3D__SWIG_1(xx, yy), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Coord3D(double xx) : this(VisionLabPINVOKE.new_Coord3D__SWIG_2(xx), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Coord3D() : this(VisionLabPINVOKE.new_Coord3D__SWIG_3(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(Coord3D c) {
    bool ret = VisionLabPINVOKE.Coord3D_IsEqual_Op(swigCPtr, Coord3D.getCPtr(c));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(Coord3D c) {
    bool ret = VisionLabPINVOKE.Coord3D_Not(swigCPtr, Coord3D.getCPtr(c));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Add_Op(Coord3D c) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Add_Op(swigCPtr, Coord3D.getCPtr(c)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Subtract_Op(Coord3D c) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Subtract_Op(swigCPtr, Coord3D.getCPtr(c)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Multiply_Op(double f) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Multiply_Op(swigCPtr, f), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Divide_Op(double f) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Divide_Op(swigCPtr, f), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Add(Coord3D c) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Add(swigCPtr, Coord3D.getCPtr(c)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Subtract(Coord3D c) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Subtract(swigCPtr, Coord3D.getCPtr(c)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Multiply(double f) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Multiply(swigCPtr, f), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Coord3D Divide(double f) {
    Coord3D ret = new Coord3D(VisionLabPINVOKE.Coord3D_Divide(swigCPtr, f), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SmallerThan(Coord3D arg0) {
    bool ret = VisionLabPINVOKE.Coord3D_SmallerThan(swigCPtr, Coord3D.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double x {
    set {
      VisionLabPINVOKE.Coord3D_x_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.Coord3D_x_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double y {
    set {
      VisionLabPINVOKE.Coord3D_y_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.Coord3D_y_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double z {
    set {
      VisionLabPINVOKE.Coord3D_z_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.Coord3D_z_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
