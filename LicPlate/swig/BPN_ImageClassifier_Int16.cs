/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BPN_ImageClassifier_Int16 : BPN_Classifier {
  private HandleRef swigCPtr;

  internal BPN_ImageClassifier_Int16(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.BPN_ImageClassifier_Int16_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BPN_ImageClassifier_Int16 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_ImageClassifier_Int16() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_ImageClassifier_Int16(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BPN_ImageClassifier_Int16() : this(VisionLabPINVOKE.new_BPN_ImageClassifier_Int16__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BPN_ImageClassifier_Int16(int nrPixels, int nrHiddens1, int nrHiddens2, int nrClasses, BiasNodes bias, double minInput, double maxInput) : this(VisionLabPINVOKE.new_BPN_ImageClassifier_Int16__SWIG_1(nrPixels, nrHiddens1, nrHiddens2, nrClasses, (int)bias, minInput, maxInput), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainImage(double learnRate, double momentum, Int16Image image, int classNr) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_TrainImage(swigCPtr, learnRate, momentum, Int16Image.getCPtr(image), classNr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainImageSet(int nrOfEpochs, double learnRate, double momentum, vector_Int16Image images, vector_int classes, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_TrainImageSet(swigCPtr, nrOfEpochs, learnRate, momentum, vector_Int16Image.getCPtr(images), vector_int.getCPtr(classes), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainClassImageSet(int nrOfEpochs, double learnRate, double momentum, ClassImageSet_Int16 cis, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_TrainClassImageSet(swigCPtr, nrOfEpochs, learnRate, momentum, ClassImageSet_Int16.getCPtr(cis), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Classify(Int16Image image, ref double confidency) {
    int ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_Classify(swigCPtr, Int16Image.getCPtr(image), ref confidency);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ClassifyOutputTab(Int16Image image, vector_ClassOutput outputTab) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_ClassifyOutputTab(swigCPtr, Int16Image.getCPtr(image), vector_ClassOutput.getCPtr(outputTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateImage(Int16Image image, int classExp, ref int classRes, ref double confidency, vector_double output) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_EvaluateImage(swigCPtr, Int16Image.getCPtr(image), classExp, ref classRes, ref confidency, vector_double.getCPtr(output));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateImageSet(vector_Int16Image images, vector_int classesExp, vector_int classesRes, vector_double confidencies, vector_vector_double outputs, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_EvaluateImageSet(swigCPtr, vector_Int16Image.getCPtr(images), vector_int.getCPtr(classesExp), vector_int.getCPtr(classesRes), vector_double.getCPtr(confidencies), vector_vector_double.getCPtr(outputs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateClassImageSet(ClassImageSet_Int16 cis, vector_int classesRes, vector_double confidencies, vector_vector_double outputs, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Int16_EvaluateClassImageSet(swigCPtr, ClassImageSet_Int16.getCPtr(cis), vector_int.getCPtr(classesRes), vector_double.getCPtr(confidencies), vector_vector_double.getCPtr(outputs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
