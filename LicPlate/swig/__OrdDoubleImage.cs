/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class __OrdDoubleImage : __NumDoubleImage {
  private HandleRef swigCPtr;

  internal __OrdDoubleImage(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__OrdDoubleImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(__OrdDoubleImage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~__OrdDoubleImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___OrdDoubleImage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public __OrdDoubleImage() : this(VisionLabPINVOKE.new___OrdDoubleImage__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdDoubleImage(int height, int width) : this(VisionLabPINVOKE.new___OrdDoubleImage__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdDoubleImage(HeightWidth hw) : this(VisionLabPINVOKE.new___OrdDoubleImage__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdDoubleImage(__OrdDoubleImage image) : this(VisionLabPINVOKE.new___OrdDoubleImage__SWIG_3(__OrdDoubleImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __OrdDoubleImage(__NumDoubleImage image) : this(VisionLabPINVOKE.new___OrdDoubleImage__SWIG_4(__NumDoubleImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.__OrdDoubleImage_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, __OrdDoubleImage properties) {
    VisionLabPINVOKE.__OrdDoubleImage_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), __OrdDoubleImage.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public static double BackGround() {
    double ret = VisionLabPINVOKE.__OrdDoubleImage_BackGround();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double Object() {
    double ret = VisionLabPINVOKE.__OrdDoubleImage_Object();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
