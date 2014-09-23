/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class __NumYUV888Image : Image {
  private HandleRef swigCPtr;

  internal __NumYUV888Image(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__NumYUV888Image_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(__NumYUV888Image obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~__NumYUV888Image() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___NumYUV888Image(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public __NumYUV888Image() : this(VisionLabPINVOKE.new___NumYUV888Image__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV888Image(int height, int width) : this(VisionLabPINVOKE.new___NumYUV888Image__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV888Image(HeightWidth hw) : this(VisionLabPINVOKE.new___NumYUV888Image__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV888Image(__NumYUV888Image image) : this(VisionLabPINVOKE.new___NumYUV888Image__SWIG_3(__NumYUV888Image.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Clear() {
    VisionLabPINVOKE.__NumYUV888Image_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width, bool deleteOrg) {
    VisionLabPINVOKE.__NumYUV888Image_SetBuf__SWIG_0(swigCPtr, buf, height, width, deleteOrg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width) {
    VisionLabPINVOKE.__NumYUV888Image_SetBuf__SWIG_1(swigCPtr, buf, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.__NumYUV888Image_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, __NumYUV888Image properties) {
    VisionLabPINVOKE.__NumYUV888Image_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), __NumYUV888Image.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadAsciiFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumYUV888Image_ReadAsciiFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteAsciiToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumYUV888Image_WriteAsciiToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadBinFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumYUV888Image_ReadBinFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteBinToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumYUV888Image_WriteBinToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV888Pixel GetFirstPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.__NumYUV888Image_GetFirstPixelPtr(swigCPtr);
    YUV888Pixel ret = (cPtr == IntPtr.Zero) ? null : new YUV888Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel GetLastPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.__NumYUV888Image_GetLastPixelPtr(swigCPtr);
    YUV888Pixel ret = (cPtr == IntPtr.Zero) ? null : new YUV888Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumYUV888Image Assign_Op(__NumYUV888Image image) {
    __NumYUV888Image ret = new __NumYUV888Image(VisionLabPINVOKE.__NumYUV888Image_Assign_Op__SWIG_0(swigCPtr, __NumYUV888Image.getCPtr(image)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumYUV888Image Assign_Op(YUV888Pixel pixel) {
    __NumYUV888Image ret = new __NumYUV888Image(VisionLabPINVOKE.__NumYUV888Image_Assign_Op__SWIG_1(swigCPtr, YUV888Pixel.getCPtr(pixel)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEqual_Op(__NumYUV888Image image) {
    bool ret = VisionLabPINVOKE.__NumYUV888Image_IsEqual_Op(swigCPtr, __NumYUV888Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(__NumYUV888Image image) {
    bool ret = VisionLabPINVOKE.__NumYUV888Image_Not(swigCPtr, __NumYUV888Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(int x, int y) {
    bool ret = VisionLabPINVOKE.__NumYUV888Image_CheckCoord__SWIG_0(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(XYCoord xy) {
    bool ret = VisionLabPINVOKE.__NumYUV888Image_CheckCoord__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel GetPixelPtr(int x, int y) {
    IntPtr cPtr = VisionLabPINVOKE.__NumYUV888Image_GetPixelPtr__SWIG_0(swigCPtr, x, y);
    YUV888Pixel ret = (cPtr == IntPtr.Zero) ? null : new YUV888Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV888Pixel GetPixelPtr(XYCoord xy) {
    IntPtr cPtr = VisionLabPINVOKE.__NumYUV888Image_GetPixelPtr__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    YUV888Pixel ret = (cPtr == IntPtr.Zero) ? null : new YUV888Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XYCoord GetXYCoord(YUV888Pixel ptr) {
    XYCoord ret = new XYCoord(VisionLabPINVOKE.__NumYUV888Image_GetXYCoord(swigCPtr, YUV888Pixel.getCPtr(ptr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPixel(int x, int y, YUV888Pixel value) {
    VisionLabPINVOKE.__NumYUV888Image_SetPixel(swigCPtr, x, y, YUV888Pixel.getCPtr(value));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
