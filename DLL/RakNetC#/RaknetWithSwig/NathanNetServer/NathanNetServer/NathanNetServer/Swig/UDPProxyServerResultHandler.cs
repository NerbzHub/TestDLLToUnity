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

public class UDPProxyServerResultHandler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UDPProxyServerResultHandler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UDPProxyServerResultHandler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UDPProxyServerResultHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_UDPProxyServerResultHandler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UDPProxyServerResultHandler() : this(RakNetPINVOKE.CSharp_RakNet_new_UDPProxyServerResultHandler(), true) {
    SwigDirectorConnect();
  }

  public virtual void OnLoginSuccess(RakString usedPassword, UDPProxyServer proxyServerPlugin) {
    RakNetPINVOKE.CSharp_RakNet_UDPProxyServerResultHandler_OnLoginSuccess(swigCPtr, RakString.getCPtr(usedPassword), UDPProxyServer.getCPtr(proxyServerPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnAlreadyLoggedIn(RakString usedPassword, UDPProxyServer proxyServerPlugin) {
    RakNetPINVOKE.CSharp_RakNet_UDPProxyServerResultHandler_OnAlreadyLoggedIn(swigCPtr, RakString.getCPtr(usedPassword), UDPProxyServer.getCPtr(proxyServerPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnNoPasswordSet(RakString usedPassword, UDPProxyServer proxyServerPlugin) {
    RakNetPINVOKE.CSharp_RakNet_UDPProxyServerResultHandler_OnNoPasswordSet(swigCPtr, RakString.getCPtr(usedPassword), UDPProxyServer.getCPtr(proxyServerPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnWrongPassword(RakString usedPassword, UDPProxyServer proxyServerPlugin) {
    RakNetPINVOKE.CSharp_RakNet_UDPProxyServerResultHandler_OnWrongPassword(swigCPtr, RakString.getCPtr(usedPassword), UDPProxyServer.getCPtr(proxyServerPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnLoginSuccess", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateUDPProxyServerResultHandler_0(SwigDirectorOnLoginSuccess);
    if (SwigDerivedClassHasMethod("OnAlreadyLoggedIn", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateUDPProxyServerResultHandler_1(SwigDirectorOnAlreadyLoggedIn);
    if (SwigDerivedClassHasMethod("OnNoPasswordSet", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateUDPProxyServerResultHandler_2(SwigDirectorOnNoPasswordSet);
    if (SwigDerivedClassHasMethod("OnWrongPassword", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateUDPProxyServerResultHandler_3(SwigDirectorOnWrongPassword);
    RakNetPINVOKE.CSharp_RakNet_UDPProxyServerResultHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(UDPProxyServerResultHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnLoginSuccess(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin) {
    OnLoginSuccess(new RakString(usedPassword, true), (proxyServerPlugin == global::System.IntPtr.Zero) ? null : new UDPProxyServer(proxyServerPlugin, false));
  }

  private void SwigDirectorOnAlreadyLoggedIn(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin) {
    OnAlreadyLoggedIn(new RakString(usedPassword, true), (proxyServerPlugin == global::System.IntPtr.Zero) ? null : new UDPProxyServer(proxyServerPlugin, false));
  }

  private void SwigDirectorOnNoPasswordSet(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin) {
    OnNoPasswordSet(new RakString(usedPassword, true), (proxyServerPlugin == global::System.IntPtr.Zero) ? null : new UDPProxyServer(proxyServerPlugin, false));
  }

  private void SwigDirectorOnWrongPassword(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin) {
    OnWrongPassword(new RakString(usedPassword, true), (proxyServerPlugin == global::System.IntPtr.Zero) ? null : new UDPProxyServer(proxyServerPlugin, false));
  }

  public delegate void SwigDelegateUDPProxyServerResultHandler_0(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin);
  public delegate void SwigDelegateUDPProxyServerResultHandler_1(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin);
  public delegate void SwigDelegateUDPProxyServerResultHandler_2(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin);
  public delegate void SwigDelegateUDPProxyServerResultHandler_3(global::System.IntPtr usedPassword, global::System.IntPtr proxyServerPlugin);

  private SwigDelegateUDPProxyServerResultHandler_0 swigDelegate0;
  private SwigDelegateUDPProxyServerResultHandler_1 swigDelegate1;
  private SwigDelegateUDPProxyServerResultHandler_2 swigDelegate2;
  private SwigDelegateUDPProxyServerResultHandler_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(RakString), typeof(UDPProxyServer) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(RakString), typeof(UDPProxyServer) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(RakString), typeof(UDPProxyServer) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(RakString), typeof(UDPProxyServer) };
}

}
