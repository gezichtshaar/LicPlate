/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class __vector_NumYUV888Image : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerable<__NumYUV888Image>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal __vector_NumYUV888Image(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(__vector_NumYUV888Image obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~__vector_NumYUV888Image() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___vector_NumYUV888Image(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public __vector_NumYUV888Image(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (__NumYUV888Image element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public __NumYUV888Image this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(__NumYUV888Image[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(__NumYUV888Image[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, __NumYUV888Image[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<__NumYUV888Image> System.Collections.Generic.IEnumerable<__NumYUV888Image>.GetEnumerator() {
    return new __vector_NumYUV888ImageEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new __vector_NumYUV888ImageEnumerator(this);
  }

  public __vector_NumYUV888ImageEnumerator GetEnumerator() {
    return new __vector_NumYUV888ImageEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class __vector_NumYUV888ImageEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<__NumYUV888Image>
#endif
  {
    private __vector_NumYUV888Image collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public __vector_NumYUV888ImageEnumerator(__vector_NumYUV888Image collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public __NumYUV888Image Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (__NumYUV888Image)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    VisionLabPINVOKE.__vector_NumYUV888Image_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(__NumYUV888Image x) {
    VisionLabPINVOKE.__vector_NumYUV888Image_Add(swigCPtr, __NumYUV888Image.getCPtr(x));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = VisionLabPINVOKE.__vector_NumYUV888Image_size(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = VisionLabPINVOKE.__vector_NumYUV888Image_capacity(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    VisionLabPINVOKE.__vector_NumYUV888Image_reserve(swigCPtr, n);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_NumYUV888Image() : this(VisionLabPINVOKE.new___vector_NumYUV888Image__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_NumYUV888Image(__vector_NumYUV888Image other) : this(VisionLabPINVOKE.new___vector_NumYUV888Image__SWIG_1(__vector_NumYUV888Image.getCPtr(other)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_NumYUV888Image(int capacity) : this(VisionLabPINVOKE.new___vector_NumYUV888Image__SWIG_2(capacity), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  private __NumYUV888Image getitemcopy(int index) {
    __NumYUV888Image ret = new __NumYUV888Image(VisionLabPINVOKE.__vector_NumYUV888Image_getitemcopy(swigCPtr, index), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private __NumYUV888Image getitem(int index) {
    __NumYUV888Image ret = new __NumYUV888Image(VisionLabPINVOKE.__vector_NumYUV888Image_getitem(swigCPtr, index), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, __NumYUV888Image val) {
    VisionLabPINVOKE.__vector_NumYUV888Image_setitem(swigCPtr, index, __NumYUV888Image.getCPtr(val));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(__vector_NumYUV888Image values) {
    VisionLabPINVOKE.__vector_NumYUV888Image_AddRange(swigCPtr, __vector_NumYUV888Image.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_NumYUV888Image GetRange(int index, int count) {
    IntPtr cPtr = VisionLabPINVOKE.__vector_NumYUV888Image_GetRange(swigCPtr, index, count);
    __vector_NumYUV888Image ret = (cPtr == IntPtr.Zero) ? null : new __vector_NumYUV888Image(cPtr, true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, __NumYUV888Image x) {
    VisionLabPINVOKE.__vector_NumYUV888Image_Insert(swigCPtr, index, __NumYUV888Image.getCPtr(x));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, __vector_NumYUV888Image values) {
    VisionLabPINVOKE.__vector_NumYUV888Image_InsertRange(swigCPtr, index, __vector_NumYUV888Image.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    VisionLabPINVOKE.__vector_NumYUV888Image_RemoveAt(swigCPtr, index);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    VisionLabPINVOKE.__vector_NumYUV888Image_RemoveRange(swigCPtr, index, count);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public static __vector_NumYUV888Image Repeat(__NumYUV888Image value, int count) {
    IntPtr cPtr = VisionLabPINVOKE.__vector_NumYUV888Image_Repeat(__NumYUV888Image.getCPtr(value), count);
    __vector_NumYUV888Image ret = (cPtr == IntPtr.Zero) ? null : new __vector_NumYUV888Image(cPtr, true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    VisionLabPINVOKE.__vector_NumYUV888Image_Reverse__SWIG_0(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    VisionLabPINVOKE.__vector_NumYUV888Image_Reverse__SWIG_1(swigCPtr, index, count);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, __vector_NumYUV888Image values) {
    VisionLabPINVOKE.__vector_NumYUV888Image_SetRange(swigCPtr, index, __vector_NumYUV888Image.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
