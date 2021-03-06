/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PatternMatcher_Int32 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PatternMatcher_Int32(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PatternMatcher_Int32 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PatternMatcher_Int32() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_PatternMatcher_Int32(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual int AddPattern(Int32Image image, string name) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int32_AddPattern(swigCPtr, Int32Image.getCPtr(image), name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void RemovePattern(string name) {
    VisionLabPINVOKE.PatternMatcher_Int32_RemovePattern(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int BestMatch(Int32Image blob, float beginAngle, float endAngle, ref float confidency, ref float error, ref float scale, ref float angle) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int32_BestMatch(swigCPtr, Int32Image.getCPtr(blob), beginAngle, endAngle, ref confidency, ref error, ref scale, ref angle);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float AllMatches(Int32Image blob, float beginAngle, float endAngle, vector_PatternMatchResult tab) {
    float ret = VisionLabPINVOKE.PatternMatcher_Int32_AllMatches(swigCPtr, Int32Image.getCPtr(blob), beginAngle, endAngle, vector_PatternMatchResult.getCPtr(tab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float EvaluateClassImageSet(ClassImageSet_Int32 cis, float beginAngle, float endAngle, vector_PatternEvalResult tabs, ref float meanError) {
    float ret = VisionLabPINVOKE.PatternMatcher_Int32_EvaluateClassImageSet(swigCPtr, ClassImageSet_Int32.getCPtr(cis), beginAngle, endAngle, vector_PatternEvalResult.getCPtr(tabs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FindPatterns(Int32Image image, float maxError, float minConfindence, float beginAngle, float endAngle, vector_PatternMatchResult labelTab, vector_vector_int patTab) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int32_FindPatterns(swigCPtr, Int32Image.getCPtr(image), maxError, minConfindence, beginAngle, endAngle, vector_PatternMatchResult.getCPtr(labelTab), vector_vector_int.getCPtr(patTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetImageType() {
    string ret = VisionLabPINVOKE.PatternMatcher_Int32_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t GetPatternNamesTab() {
    SWIGTYPE_p_std__mapT_std__string_int_t ret = new SWIGTYPE_p_std__mapT_std__string_int_t(VisionLabPINVOKE.PatternMatcher_Int32_GetPatternNamesTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NumberOfPatterns() {
    int ret = VisionLabPINVOKE.PatternMatcher_Int32_NumberOfPatterns(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string PatternName(int id) {
    string ret = VisionLabPINVOKE.PatternMatcher_Int32_PatternName(swigCPtr, id);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int PatternId(string name) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int32_PatternId(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Int32Image PatternImage(int id) {
    Int32Image ret = new Int32Image(VisionLabPINVOKE.PatternMatcher_Int32_PatternImage__SWIG_0(swigCPtr, id), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Int32Image PatternImage(string name) {
    Int32Image ret = new Int32Image(VisionLabPINVOKE.PatternMatcher_Int32_PatternImage__SWIG_1(swigCPtr, name), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void WriteToFile(string fileName) {
    VisionLabPINVOKE.PatternMatcher_Int32_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReadFromFile(string fileName) {
    VisionLabPINVOKE.PatternMatcher_Int32_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.PatternMatcher_Int32_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.PatternMatcher_Int32_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
