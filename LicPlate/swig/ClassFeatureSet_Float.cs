/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ClassFeatureSet_Float : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClassFeatureSet_Float(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ClassFeatureSet_Float obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClassFeatureSet_Float() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_ClassFeatureSet_Float(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ClassFeatureSet_Float() : this(VisionLabPINVOKE.new_ClassFeatureSet_Float__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassFeatureSet_Float(string info) : this(VisionLabPINVOKE.new_ClassFeatureSet_Float__SWIG_1(info), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Float_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddClass(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_AddClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClassId(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_ClassId(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ClassName(int classId) {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Float_ClassName(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t GetClassTab() {
    SWIGTYPE_p_std__mapT_std__string_int_t ret = new SWIGTYPE_p_std__mapT_std__string_int_t(VisionLabPINVOKE.ClassFeatureSet_Float_GetClassTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int MaxClassId() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_MaxClassId(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveClass(string className) {
    VisionLabPINVOKE.ClassFeatureSet_Float_RemoveClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddImage(string className, FloatImage image) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_AddImage(swigCPtr, className, FloatImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FloatImage GetImage(string className, int imageIndex) {
    FloatImage ret = new FloatImage(VisionLabPINVOKE.ClassFeatureSet_Float_GetImage(swigCPtr, className, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetClassIds(vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Float_GetClassIds(swigCPtr, vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrOfImages(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_NrOfImages(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveImage(string className, int imageIndex) {
    VisionLabPINVOKE.ClassFeatureSet_Float_RemoveImage(swigCPtr, className, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddFeature(string featureName) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_AddFeature(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FeatureId(string featureName) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_FeatureId(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string FeatureName(int featureId) {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Float_FeatureName(swigCPtr, featureId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t GetFeatureNameTab() {
    SWIGTYPE_p_std__mapT_std__string_int_t ret = new SWIGTYPE_p_std__mapT_std__string_int_t(VisionLabPINVOKE.ClassFeatureSet_Float_GetFeatureNameTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveFeature(string featureName) {
    VisionLabPINVOKE.ClassFeatureSet_Float_RemoveFeature(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNrFeatures() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_GetNrFeatures(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_double GetFeaturesImage(string className, int imageIndex) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Float_GetFeaturesImage(swigCPtr, className, imageIndex), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFeaturesImage(string className, int imageIndex, vector_double f) {
    VisionLabPINVOKE.ClassFeatureSet_Float_SetFeaturesImage(swigCPtr, className, imageIndex, vector_double.getCPtr(f));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSet(vector_vector_double features, vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Float_GetSet(swigCPtr, vector_vector_double.getCPtr(features), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool SelectFeature(string featureName, bool selected) {
    bool ret = VisionLabPINVOKE.ClassFeatureSet_Float_SelectFeature(swigCPtr, featureName, selected);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNrSelectedFeatures() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Float_GetNrSelectedFeatures(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_bool GetSelectTab() {
    vector_bool ret = new vector_bool(VisionLabPINVOKE.ClassFeatureSet_Float_GetSelectTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSelectTab(vector_bool tab) {
    VisionLabPINVOKE.ClassFeatureSet_Float_SetSelectTab(swigCPtr, vector_bool.getCPtr(tab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_double GetSelectedFeaturesImage(string className, int imageIndex) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Float_GetSelectedFeaturesImage(swigCPtr, className, imageIndex), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetSelectedSet(vector_vector_double features, vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Float_GetSelectedSet(swigCPtr, vector_vector_double.getCPtr(features), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_double GetSelectedFeatures(vector_double features) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Float_GetSelectedFeatures(swigCPtr, vector_double.getCPtr(features)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_MinMaxInput GetMinMaxTab() {
    vector_MinMaxInput ret = new vector_MinMaxInput(VisionLabPINVOKE.ClassFeatureSet_Float_GetMinMaxTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_MinMaxInput GetSelectedMinMaxTab() {
    vector_MinMaxInput ret = new vector_MinMaxInput(VisionLabPINVOKE.ClassFeatureSet_Float_GetSelectedMinMaxTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMinMaxTab(vector_MinMaxInput minMaxTab) {
    VisionLabPINVOKE.ClassFeatureSet_Float_SetMinMaxTab(swigCPtr, vector_MinMaxInput.getCPtr(minMaxTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CalcMinMaxTab() {
    VisionLabPINVOKE.ClassFeatureSet_Float_CalcMinMaxTab(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ResetMinMaxTab() {
    VisionLabPINVOKE.ClassFeatureSet_Float_ResetMinMaxTab(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetInfo() {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Float_GetInfo(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetScriptName(SWIGTYPE_p_QString name) {
    VisionLabPINVOKE.ClassFeatureSet_Float_SetScriptName(swigCPtr, SWIGTYPE_p_QString.getCPtr(name));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString GetScriptName() {
    SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Float_GetScriptName(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.ClassFeatureSet_Float_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.ClassFeatureSet_Float_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.ClassFeatureSet_Float_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.ClassFeatureSet_Float_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString info {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_info_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Float_info_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_QString scriptName {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_scriptName_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Float_scriptName_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t classTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_classTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_classTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t featureNameTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_featureNameTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_featureNameTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_FloatImage imageTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_imageTab_set(swigCPtr, vector_vector_FloatImage.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_imageTab_get(swigCPtr);
      vector_vector_FloatImage ret = (cPtr == IntPtr.Zero) ? null : new vector_vector_FloatImage(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_vector_double featureTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_featureTab_set(swigCPtr, vector_vector_vector_double.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_featureTab_get(swigCPtr);
      vector_vector_vector_double ret = (cPtr == IntPtr.Zero) ? null : new vector_vector_vector_double(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_bool selectTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_selectTab_set(swigCPtr, vector_bool.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_selectTab_get(swigCPtr);
      vector_bool ret = (cPtr == IntPtr.Zero) ? null : new vector_bool(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_MinMaxInput minMaxTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Float_minMaxTab_set(swigCPtr, vector_MinMaxInput.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Float_minMaxTab_get(swigCPtr);
      vector_MinMaxInput ret = (cPtr == IntPtr.Zero) ? null : new vector_MinMaxInput(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void Init(string info) {
    VisionLabPINVOKE.ClassFeatureSet_Float_Init(swigCPtr, info);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
