/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BlobMatcher_Int16 : PatternMatcher_Int16 {
  private HandleRef swigCPtr;

  internal BlobMatcher_Int16(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.BlobMatcher_Int16_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BlobMatcher_Int16 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlobMatcher_Int16() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BlobMatcher_Int16(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BlobMatcher_Int16(int nrOfRotations, float perimeterFillRatio, int fillSampleSize, int randomSampleSize) : this(VisionLabPINVOKE.new_BlobMatcher_Int16__SWIG_0(nrOfRotations, perimeterFillRatio, fillSampleSize, randomSampleSize), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobMatcher_Int16(int nrOfRotations, float perimeterFillRatio, int fillSampleSize) : this(VisionLabPINVOKE.new_BlobMatcher_Int16__SWIG_1(nrOfRotations, perimeterFillRatio, fillSampleSize), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobMatcher_Int16(int nrOfRotations, float perimeterFillRatio) : this(VisionLabPINVOKE.new_BlobMatcher_Int16__SWIG_2(nrOfRotations, perimeterFillRatio), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobMatcher_Int16(int nrOfRotations) : this(VisionLabPINVOKE.new_BlobMatcher_Int16__SWIG_3(nrOfRotations), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobMatcher_Int16() : this(VisionLabPINVOKE.new_BlobMatcher_Int16__SWIG_4(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ChangeParams(int nrOfRotations, float perimeterFillRatio, int fillSampleSize, int randomSampleSize) {
    VisionLabPINVOKE.BlobMatcher_Int16_ChangeParams__SWIG_0(swigCPtr, nrOfRotations, perimeterFillRatio, fillSampleSize, randomSampleSize);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ChangeParams(int nrOfRotations, float perimeterFillRatio, int fillSampleSize) {
    VisionLabPINVOKE.BlobMatcher_Int16_ChangeParams__SWIG_1(swigCPtr, nrOfRotations, perimeterFillRatio, fillSampleSize);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ChangeParams(int nrOfRotations, float perimeterFillRatio) {
    VisionLabPINVOKE.BlobMatcher_Int16_ChangeParams__SWIG_2(swigCPtr, nrOfRotations, perimeterFillRatio);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ChangeParams(int nrOfRotations) {
    VisionLabPINVOKE.BlobMatcher_Int16_ChangeParams__SWIG_3(swigCPtr, nrOfRotations);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int AddPattern(Int16Image image, string name) {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_AddPattern(swigCPtr, Int16Image.getCPtr(image), name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void RemovePattern(string name) {
    VisionLabPINVOKE.BlobMatcher_Int16_RemovePattern(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int BestMatch(Int16Image blob, float beginAngle, float endAngle, ref float confidence, ref float error, ref float scale, ref float angle) {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_BestMatch(swigCPtr, Int16Image.getCPtr(blob), beginAngle, endAngle, ref confidence, ref error, ref scale, ref angle);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float AllMatches(Int16Image blob, float beginAngle, float endAngle, vector_PatternMatchResult tab) {
    float ret = VisionLabPINVOKE.BlobMatcher_Int16_AllMatches(swigCPtr, Int16Image.getCPtr(blob), beginAngle, endAngle, vector_PatternMatchResult.getCPtr(tab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float EvaluateClassImageSet(ClassImageSet_Int16 cis, float beginAngle, float endAngle, vector_PatternEvalResult tabs, ref float meanError) {
    float ret = VisionLabPINVOKE.BlobMatcher_Int16_EvaluateClassImageSet(swigCPtr, ClassImageSet_Int16.getCPtr(cis), beginAngle, endAngle, vector_PatternEvalResult.getCPtr(tabs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int FindPatterns(Int16Image image, float maxError, float minConfindence, float beginAngle, float endAngle, vector_PatternMatchResult labelTab, vector_vector_int patTab) {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_FindPatterns(swigCPtr, Int16Image.getCPtr(image), maxError, minConfindence, beginAngle, endAngle, vector_PatternMatchResult.getCPtr(labelTab), vector_vector_int.getCPtr(patTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Int16Image PatternImage(int id) {
    Int16Image ret = new Int16Image(VisionLabPINVOKE.BlobMatcher_Int16_PatternImage__SWIG_0(swigCPtr, id), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Int16Image PatternImage(string name) {
    Int16Image ret = new Int16Image(VisionLabPINVOKE.BlobMatcher_Int16_PatternImage__SWIG_1(swigCPtr, name), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void WriteToFile(string fileName) {
    VisionLabPINVOKE.BlobMatcher_Int16_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadFromFile(string fileName) {
    VisionLabPINVOKE.BlobMatcher_Int16_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.BlobMatcher_Int16_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.BlobMatcher_Int16_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrOfRotations() {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_NrOfRotations(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float FillRatio() {
    float ret = VisionLabPINVOKE.BlobMatcher_Int16_FillRatio(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FillSize() {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_FillSize(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SampleSize() {
    int ret = VisionLabPINVOKE.BlobMatcher_Int16_SampleSize(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}