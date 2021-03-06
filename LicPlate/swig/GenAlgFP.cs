/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GenAlgFP : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GenAlgFP(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GenAlgFP obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GenAlgFP() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_GenAlgFP(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessCmd cmd, int populationSize, int trace, string traceFileName) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_0(vector_FPParamDesc.getCPtr(tab), FitnessCmd.getCPtr(cmd), populationSize, trace, traceFileName), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessCmd cmd, int populationSize, int trace) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_1(vector_FPParamDesc.getCPtr(tab), FitnessCmd.getCPtr(cmd), populationSize, trace), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessCmd cmd, int populationSize) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_2(vector_FPParamDesc.getCPtr(tab), FitnessCmd.getCPtr(cmd), populationSize), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessCmd cmd) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_3(vector_FPParamDesc.getCPtr(tab), FitnessCmd.getCPtr(cmd)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessAllCmd cmd, int populationSize, int trace, string traceFileName) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_4(vector_FPParamDesc.getCPtr(tab), FitnessAllCmd.getCPtr(cmd), populationSize, trace, traceFileName), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessAllCmd cmd, int populationSize, int trace) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_5(vector_FPParamDesc.getCPtr(tab), FitnessAllCmd.getCPtr(cmd), populationSize, trace), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessAllCmd cmd, int populationSize) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_6(vector_FPParamDesc.getCPtr(tab), FitnessAllCmd.getCPtr(cmd), populationSize), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public GenAlgFP(vector_FPParamDesc tab, FitnessAllCmd cmd) : this(VisionLabPINVOKE.new_GenAlgFP__SWIG_7(vector_FPParamDesc.getCPtr(tab), FitnessAllCmd.getCPtr(cmd)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RandomInitialize(int populationSize) {
    VisionLabPINVOKE.GenAlgFP_RandomInitialize(swigCPtr, populationSize);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFounder(int populationSize, vector_double founder) {
    VisionLabPINVOKE.GenAlgFP_SetFounder(swigCPtr, populationSize, vector_double.getCPtr(founder));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFounders(vector_vector_double parents) {
    VisionLabPINVOKE.GenAlgFP_SetFounders(swigCPtr, vector_vector_double.getCPtr(parents));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Optimize(int maxGenerations, double minError, double deltaError, double microP) {
    double ret = VisionLabPINVOKE.GenAlgFP_Optimize(swigCPtr, maxGenerations, minError, deltaError, microP);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_double GetSolution() {
    vector_double ret = new vector_double(VisionLabPINVOKE.GenAlgFP_GetSolution(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_vector_double GetPopulation() {
    vector_vector_double ret = new vector_vector_double(VisionLabPINVOKE.GenAlgFP_GetPopulation(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NrOfParams() {
    int ret = VisionLabPINVOKE.GenAlgFP_NrOfParams(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Mate(vector_double child, vector_double p1, vector_double p2) {
    VisionLabPINVOKE.GenAlgFP_Mate(swigCPtr, vector_double.getCPtr(child), vector_double.getCPtr(p1), vector_double.getCPtr(p2));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MateSelf(vector_double child, vector_double p1) {
    VisionLabPINVOKE.GenAlgFP_MateSelf(swigCPtr, vector_double.getCPtr(child), vector_double.getCPtr(p1));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeltaMutation(int index, ref double f) {
    VisionLabPINVOKE.GenAlgFP_DeltaMutation(swigCPtr, index, ref f);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void MicroMutation(int index, ref double f) {
    VisionLabPINVOKE.GenAlgFP_MicroMutation(swigCPtr, index, ref f);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void TraceBestParents(string msg) {
    VisionLabPINVOKE.GenAlgFP_TraceBestParents(swigCPtr, msg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_FPParamDesc descTab {
    set {
      VisionLabPINVOKE.GenAlgFP_descTab_set(swigCPtr, vector_FPParamDesc.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.GenAlgFP_descTab_get(swigCPtr);
      vector_FPParamDesc ret = (cPtr == IntPtr.Zero) ? null : new vector_FPParamDesc(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FitnessCmd Fitness {
    set {
      VisionLabPINVOKE.GenAlgFP_Fitness_set(swigCPtr, FitnessCmd.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.GenAlgFP_Fitness_get(swigCPtr);
      FitnessCmd ret = (cPtr == IntPtr.Zero) ? null : new FitnessCmd(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FitnessAllCmd FitnessAll {
    set {
      VisionLabPINVOKE.GenAlgFP_FitnessAll_set(swigCPtr, FitnessAllCmd.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.GenAlgFP_FitnessAll_get(swigCPtr);
      FitnessAllCmd ret = (cPtr == IntPtr.Zero) ? null : new FitnessAllCmd(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_ParamsError parents {
    set {
      VisionLabPINVOKE.GenAlgFP_parents_set(swigCPtr, vector_ParamsError.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.GenAlgFP_parents_get(swigCPtr);
      vector_ParamsError ret = (cPtr == IntPtr.Zero) ? null : new vector_ParamsError(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_ParamsError offsprings {
    set {
      VisionLabPINVOKE.GenAlgFP_offsprings_set(swigCPtr, vector_ParamsError.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.GenAlgFP_offsprings_get(swigCPtr);
      vector_ParamsError ret = (cPtr == IntPtr.Zero) ? null : new vector_ParamsError(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double microP {
    set {
      VisionLabPINVOKE.GenAlgFP_microP_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.GenAlgFP_microP_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int trace {
    set {
      VisionLabPINVOKE.GenAlgFP_trace_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.GenAlgFP_trace_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string traceFileName {
    set {
      VisionLabPINVOKE.GenAlgFP_traceFileName_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = VisionLabPINVOKE.GenAlgFP_traceFileName_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool deltaMutations {
    set {
      VisionLabPINVOKE.GenAlgFP_deltaMutations_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = VisionLabPINVOKE.GenAlgFP_deltaMutations_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int genCount {
    set {
      VisionLabPINVOKE.GenAlgFP_genCount_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.GenAlgFP_genCount_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
