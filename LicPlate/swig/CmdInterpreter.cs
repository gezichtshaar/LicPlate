/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CmdInterpreter : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CmdInterpreter(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CmdInterpreter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CmdInterpreter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_CmdInterpreter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CmdInterpreter() : this(VisionLabPINVOKE.new_CmdInterpreter(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsCmd(string cmdName) {
    bool ret = VisionLabPINVOKE.CmdInterpreter_IsCmd(swigCPtr, cmdName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(string cmdName, SWIGTYPE_p_CmdInterpreter__Command command, string helpMsg, bool arg3) {
    VisionLabPINVOKE.CmdInterpreter_Insert__SWIG_0(swigCPtr, cmdName, SWIGTYPE_p_CmdInterpreter__Command.getCPtr(command), helpMsg, arg3);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(string cmdName, SWIGTYPE_p_CmdInterpreter__Command command, string helpMsg) {
    VisionLabPINVOKE.CmdInterpreter_Insert__SWIG_1(swigCPtr, cmdName, SWIGTYPE_p_CmdInterpreter__Command.getCPtr(command), helpMsg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Erase(string cmdName) {
    VisionLabPINVOKE.CmdInterpreter_Erase(swigCPtr, cmdName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Execute(SWIGTYPE_p_std__istream arg0, SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.CmdInterpreter_Execute(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0), SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsVar(string name) {
    bool ret = VisionLabPINVOKE.CmdInterpreter_IsVar(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetVar(string name) {
    string ret = VisionLabPINVOKE.CmdInterpreter_GetVar(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetVar(string name, string value) {
    VisionLabPINVOKE.CmdInterpreter_SetVar(swigCPtr, name, value);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetArrayStr(string name) {
    string ret = VisionLabPINVOKE.CmdInterpreter_GetArrayStr(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetArrayStr(string name, string value) {
    VisionLabPINVOKE.CmdInterpreter_SetArrayStr(swigCPtr, name, value);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSizeArray(string name, int size) {
    VisionLabPINVOKE.CmdInterpreter_SetSizeArray(swigCPtr, name, size);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetSizeArray(string name) {
    int ret = VisionLabPINVOKE.CmdInterpreter_GetSizeArray(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetArrayVar(string name, int index) {
    string ret = VisionLabPINVOKE.CmdInterpreter_GetArrayVar(swigCPtr, name, index);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetArrayVar(string name, int index, string value) {
    VisionLabPINVOKE.CmdInterpreter_SetArrayVar(swigCPtr, name, index, value);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CopyVar(string src, string dest) {
    VisionLabPINVOKE.CmdInterpreter_CopyVar(swigCPtr, src, dest);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int VarToArray(string var, string array) {
    int ret = VisionLabPINVOKE.CmdInterpreter_VarToArray(swigCPtr, var, array);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ArrayToVar(string array, string var) {
    VisionLabPINVOKE.CmdInterpreter_ArrayToVar(swigCPtr, array, var);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveVar(string name) {
    VisionLabPINVOKE.CmdInterpreter_RemoveVar(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAllVars() {
    VisionLabPINVOKE.CmdInterpreter_RemoveAllVars(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string ListAllVars() {
    string ret = VisionLabPINVOKE.CmdInterpreter_ListAllVars(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NrCmds() {
    int ret = VisionLabPINVOKE.CmdInterpreter_NrCmds(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetArray(string name, vector_string vs) {
    VisionLabPINVOKE.CmdInterpreter_GetArray(swigCPtr, name, vector_string.getCPtr(vs));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetArray(string name, vector_string vs) {
    VisionLabPINVOKE.CmdInterpreter_SetArray(swigCPtr, name, vector_string.getCPtr(vs));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string SubstituteVars(string istr) {
    string ret = VisionLabPINVOKE.CmdInterpreter_SubstituteVars(swigCPtr, istr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
