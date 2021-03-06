/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class YUV161616Pixel : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal YUV161616Pixel(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(YUV161616Pixel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~YUV161616Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_YUV161616Pixel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public YUV161616Pixel(int value) : this(VisionLabPINVOKE.new_YUV161616Pixel__SWIG_0(value), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV161616Pixel() : this(VisionLabPINVOKE.new_YUV161616Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV161616Pixel(short yy, short uu, short vv) : this(VisionLabPINVOKE.new_YUV161616Pixel__SWIG_2(yy, uu, vv), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV161616Pixel(YUV888Pixel pixel) : this(VisionLabPINVOKE.new_YUV161616Pixel__SWIG_3(YUV888Pixel.getCPtr(pixel)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(YUV161616Pixel p) {
    bool ret = VisionLabPINVOKE.YUV161616Pixel_IsEqual_Op(swigCPtr, YUV161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(YUV161616Pixel p) {
    bool ret = VisionLabPINVOKE.YUV161616Pixel_Not(swigCPtr, YUV161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Add(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Add(swigCPtr, YUV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Subtract(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Subtract(swigCPtr, YUV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Multiply(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Multiply(swigCPtr, YUV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Divide(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Divide(swigCPtr, YUV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Add_Op(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Add_Op(swigCPtr, YUV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Subtract_Op(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Subtract_Op(swigCPtr, YUV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Multiply_Op(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Multiply_Op(swigCPtr, YUV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel Divide_Op(YUV161616Pixel p) {
    YUV161616Pixel ret = new YUV161616Pixel(VisionLabPINVOKE.YUV161616Pixel_Divide_Op(swigCPtr, YUV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      IntPtr cPtr = VisionLabPINVOKE.YUV161616Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short v {
    set {
      VisionLabPINVOKE.YUV161616Pixel_v_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.YUV161616Pixel_v_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short u {
    set {
      VisionLabPINVOKE.YUV161616Pixel_u_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.YUV161616Pixel_u_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short y {
    set {
      VisionLabPINVOKE.YUV161616Pixel_y_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.YUV161616Pixel_y_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
