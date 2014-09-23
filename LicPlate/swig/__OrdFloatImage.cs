/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class __OrdFloatImage : __NumFloatImage {
  private HandleRef swigCPtr;

  internal __OrdFloatImage(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__OrdFloatImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(__OrdFloatImage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~__OrdFloatImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___OrdFloatImage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public __OrdFloatImage() : this(VisionLabPINVOKE.new___OrdFloatImage__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdFloatImage(int height, int width) : this(VisionLabPINVOKE.new___OrdFloatImage__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdFloatImage(HeightWidth hw) : this(VisionLabPINVOKE.new___OrdFloatImage__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdFloatImage(__OrdFloatImage image) : this(VisionLabPINVOKE.new___OrdFloatImage__SWIG_3(__OrdFloatImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdFloatImage(__NumFloatImage image) : this(VisionLabPINVOKE.new___OrdFloatImage__SWIG_4(__NumFloatImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.__OrdFloatImage_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, __OrdFloatImage properties) {
    VisionLabPINVOKE.__OrdFloatImage_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), __OrdFloatImage.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public static float BackGround() {
    float ret = VisionLabPINVOKE.__OrdFloatImage_BackGround();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static float Object() {
    float ret = VisionLabPINVOKE.__OrdFloatImage_Object();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
