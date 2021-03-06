//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class MessageFilter : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MessageFilter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.CSharp_RakNet_MessageFilter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MessageFilter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MessageFilter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_MessageFilter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static MessageFilter GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_MessageFilter_GetInstance();
    MessageFilter ret = (cPtr == global::System.IntPtr.Zero) ? null : new MessageFilter(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(MessageFilter i) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_DestroyInstance(MessageFilter.getCPtr(i));
  }

  public MessageFilter() : this(RakNetPINVOKE.CSharp_RakNet_new_MessageFilter(), true) {
  }

  public void SetAutoAddNewConnectionsToFilter(int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetAutoAddNewConnectionsToFilter(swigCPtr, filterSetID);
  }

  public void SetAllowMessageID(bool allow, int messageIDStart, int messageIDEnd, int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetAllowMessageID(swigCPtr, allow, messageIDStart, messageIDEnd, filterSetID);
  }

  public void SetAllowRPC4(bool allow, string uniqueID, int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetAllowRPC4(swigCPtr, allow, uniqueID, filterSetID);
  }

  public void SetActionOnDisallowedMessage(bool kickOnDisallowed, bool banOnDisallowed, uint banTimeMS, int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetActionOnDisallowedMessage(swigCPtr, kickOnDisallowed, banOnDisallowed, banTimeMS, filterSetID);
  }

  public void SetFilterMaxTime(int allowedTimeMS, bool banOnExceed, uint banTimeMS, int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetFilterMaxTime(swigCPtr, allowedTimeMS, banOnExceed, banTimeMS, filterSetID);
  }

  public int GetSystemFilterSet(AddressOrGUID addressOrGUID) {
    int ret = RakNetPINVOKE.CSharp_RakNet_MessageFilter_GetSystemFilterSet(swigCPtr, AddressOrGUID.getCPtr(addressOrGUID));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSystemFilterSet(AddressOrGUID addressOrGUID, int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_SetSystemFilterSet(swigCPtr, AddressOrGUID.getCPtr(addressOrGUID), filterSetID);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetSystemCount(int filterSetID) {
    uint ret = RakNetPINVOKE.CSharp_RakNet_MessageFilter_GetSystemCount(swigCPtr, filterSetID);
    return ret;
  }

  public uint GetFilterSetCount() {
    uint ret = RakNetPINVOKE.CSharp_RakNet_MessageFilter_GetFilterSetCount(swigCPtr);
    return ret;
  }

  public int GetFilterSetIDByIndex(uint index) {
    int ret = RakNetPINVOKE.CSharp_RakNet_MessageFilter_GetFilterSetIDByIndex(swigCPtr, index);
    return ret;
  }

  public void DeleteFilterSet(int filterSetID) {
    RakNetPINVOKE.CSharp_RakNet_MessageFilter_DeleteFilterSet(swigCPtr, filterSetID);
  }

}

}
