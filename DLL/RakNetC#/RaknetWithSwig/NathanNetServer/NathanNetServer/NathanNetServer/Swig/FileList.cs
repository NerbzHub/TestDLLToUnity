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

public class FileList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_FileList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FileList GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_FileList_GetInstance();
    FileList ret = (cPtr == global::System.IntPtr.Zero) ? null : new FileList(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FileList i) {
    RakNetPINVOKE.CSharp_RakNet_FileList_DestroyInstance(FileList.getCPtr(i));
  }

  public FileList() : this(RakNetPINVOKE.CSharp_RakNet_new_FileList(), true) {
  }

  public void AddFilesFromDirectory(string applicationDirectory, string subDirectory, bool writeHash, bool writeData, bool recursive, FileListNodeContext context) {
    RakNetPINVOKE.CSharp_RakNet_FileList_AddFilesFromDirectory(swigCPtr, applicationDirectory, subDirectory, writeHash, writeData, recursive, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    RakNetPINVOKE.CSharp_RakNet_FileList_Clear(swigCPtr);
  }

  public void Serialize(BitStream outBitStream) {
    RakNetPINVOKE.CSharp_RakNet_FileList_Serialize(swigCPtr, BitStream.getCPtr(outBitStream));
  }

  public bool Deserialize(BitStream inBitStream) {
    bool ret = RakNetPINVOKE.CSharp_RakNet_FileList_Deserialize(swigCPtr, BitStream.getCPtr(inBitStream));
    return ret;
  }

  public void ListMissingOrChangedFiles(string applicationDirectory, FileList missingOrChangedFiles, bool alwaysWriteHash, bool neverWriteHash) {
    RakNetPINVOKE.CSharp_RakNet_FileList_ListMissingOrChangedFiles(swigCPtr, applicationDirectory, FileList.getCPtr(missingOrChangedFiles), alwaysWriteHash, neverWriteHash);
  }

  public void GetDeltaToCurrent(FileList input, FileList output, string dirSubset, string remoteSubdir) {
    RakNetPINVOKE.CSharp_RakNet_FileList_GetDeltaToCurrent(swigCPtr, FileList.getCPtr(input), FileList.getCPtr(output), dirSubset, remoteSubdir);
  }

  public void PopulateDataFromDisk(string applicationDirectory, bool writeFileData, bool writeFileHash, bool removeUnknownFiles) {
    RakNetPINVOKE.CSharp_RakNet_FileList_PopulateDataFromDisk(swigCPtr, applicationDirectory, writeFileData, writeFileHash, removeUnknownFiles);
  }

  public void FlagFilesAsReferences() {
    RakNetPINVOKE.CSharp_RakNet_FileList_FlagFilesAsReferences(swigCPtr);
  }

  public void WriteDataToDisk(string applicationDirectory) {
    RakNetPINVOKE.CSharp_RakNet_FileList_WriteDataToDisk(swigCPtr, applicationDirectory);
  }

  public void AddFile(string filepath, string filename, FileListNodeContext context) {
    RakNetPINVOKE.CSharp_RakNet_FileList_AddFile__SWIG_0(swigCPtr, filepath, filename, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteFiles(string applicationDirectory) {
    RakNetPINVOKE.CSharp_RakNet_FileList_DeleteFiles(swigCPtr, applicationDirectory);
  }

  public void AddCallback(FileListProgress cb) {
    RakNetPINVOKE.CSharp_RakNet_FileList_AddCallback(swigCPtr, FileListProgress.getCPtr(cb));
  }

  public void RemoveCallback(FileListProgress cb) {
    RakNetPINVOKE.CSharp_RakNet_FileList_RemoveCallback(swigCPtr, FileListProgress.getCPtr(cb));
  }

  public void ClearCallbacks() {
    RakNetPINVOKE.CSharp_RakNet_FileList_ClearCallbacks(swigCPtr);
  }

  public RakNetListFileListNode fileList {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileList_fileList_set(swigCPtr, RakNetListFileListNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_FileList_fileList_get(swigCPtr);
      RakNetListFileListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetListFileListNode(cPtr, false);
      return ret;
    } 
  }

  public static bool FixEndingSlash(string str) {
    bool ret = RakNetPINVOKE.CSharp_RakNet_FileList_FixEndingSlash(str);
    return ret;
  }

  public void AddFile(string filename, string fullPathToFile, byte[] inByteArray, uint dataLength, uint fileLength, FileListNodeContext context, bool isAReference) {
    RakNetPINVOKE.CSharp_RakNet_FileList_AddFile__SWIG_1(swigCPtr, filename, fullPathToFile, inByteArray, dataLength, fileLength, FileListNodeContext.getCPtr(context), isAReference);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddFile(string filename, string fullPathToFile, byte[] inByteArray, uint dataLength, uint fileLength, FileListNodeContext context) {
    RakNetPINVOKE.CSharp_RakNet_FileList_AddFile__SWIG_2(swigCPtr, filename, fullPathToFile, inByteArray, dataLength, fileLength, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
