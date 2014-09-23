/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class YUV888Pixel : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal YUV888Pixel(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(YUV888Pixel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~YUV888Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_YUV888Pixel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public YUV888Pixel(int value) : this(VisionLabPINVOKE.new_YUV888Pixel__SWIG_0(value), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV888Pixel() : this(VisionLabPINVOKE.new_YUV888Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV888Pixel(byte r, byte g, byte b) : this(VisionLabPINVOKE.new_YUV888Pixel__SWIG_2(r, g, b), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(YUV888Pixel p) {
    bool ret = VisionLabPINVOKE.YUV888Pixel_IsEqual_Op(swigCPtr, YUV888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(YUV888Pixel p) {
    bool ret = VisionLabPINVOKE.YUV888Pixel_Not(swigCPtr, YUV888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Add(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Add(swigCPtr, YUV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Subtract(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Subtract(swigCPtr, YUV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Multiply(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Multiply(swigCPtr, YUV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Divide(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Divide(swigCPtr, YUV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Add_Op(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Add_Op(swigCPtr, YUV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Subtract_Op(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Subtract_Op(swigCPtr, YUV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Multiply_Op(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Multiply_Op(swigCPtr, YUV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel Divide_Op(YUV888Pixel p) {
    YUV888Pixel ret = new YUV888Pixel(VisionLabPINVOKE.YUV888Pixel_Divide_Op(swigCPtr, YUV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      IntPtr cPtr = VisionLabPINVOKE.YUV888Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static byte MAXValue {
    get {
      byte ret = VisionLabPINVOKE.YUV888Pixel_MAXValue_get();
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte v {
    set {
      VisionLabPINVOKE.YUV888Pixel_v_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.YUV888Pixel_v_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte u {
    set {
      VisionLabPINVOKE.YUV888Pixel_u_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.YUV888Pixel_u_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte y {
    set {
      VisionLabPINVOKE.YUV888Pixel_y_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.YUV888Pixel_y_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte pad {
    set {
      VisionLabPINVOKE.YUV888Pixel_pad_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.YUV888Pixel_pad_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}