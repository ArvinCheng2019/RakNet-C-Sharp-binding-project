/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RakPeerInterface : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakPeerInterface(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakPeerInterface obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakPeerInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakPeerInterface(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

	public virtual void GetIncomingPassword(ref string passwordData, ref int passwordDataLength  )
	{
		passwordData=CSharpGetIncomingPasswordHelper(passwordData,ref passwordDataLength);
	}

	public virtual void GetOfflinePingResponse( byte[] inOutByteArray, out uint length )
	{
		CSharpGetOfflinePingResponseHelper(inOutByteArray,out length);
	}

	public virtual bool GetConnectionList(out SystemAddress[] remoteSystems, ref ushort numberOfSystems)
	{
		RakNetListSystemAddress passVal= new RakNetListSystemAddress();
		bool returnVal = GetConnectionList(passVal,ref numberOfSystems);
		SystemAddress[] outVal = new SystemAddress[numberOfSystems];
		for (int i=0; i<numberOfSystems;i++)
		{
			outVal[i]=passVal[i];
		} 
		remoteSystems=outVal;
		return returnVal;
	}


  public static RakPeerInterface GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.RakPeerInterface_GetInstance();
    RakPeerInterface ret = (cPtr == IntPtr.Zero) ? null : new RakPeerInterface(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(RakPeerInterface i) {
    RakNetPINVOKE.RakPeerInterface_DestroyInstance(RakPeerInterface.getCPtr(i));
  }

  public virtual StartupResult Startup(uint maxConnections, SocketDescriptor socketDescriptors, uint socketDescriptorCount, int threadPriority) {
    StartupResult ret = (StartupResult)RakNetPINVOKE.RakPeerInterface_Startup__SWIG_0(swigCPtr, maxConnections, SocketDescriptor.getCPtr(socketDescriptors), socketDescriptorCount, threadPriority);
    return ret;
  }

  public virtual StartupResult Startup(uint maxConnections, SocketDescriptor socketDescriptors, uint socketDescriptorCount) {
    StartupResult ret = (StartupResult)RakNetPINVOKE.RakPeerInterface_Startup__SWIG_1(swigCPtr, maxConnections, SocketDescriptor.getCPtr(socketDescriptors), socketDescriptorCount);
    return ret;
  }

  public virtual bool InitializeSecurity(string publicKey, string privateKey, bool bRequireClientKey) {
    bool ret = RakNetPINVOKE.RakPeerInterface_InitializeSecurity__SWIG_0(swigCPtr, publicKey, privateKey, bRequireClientKey);
    return ret;
  }

  public virtual bool InitializeSecurity(string publicKey, string privateKey) {
    bool ret = RakNetPINVOKE.RakPeerInterface_InitializeSecurity__SWIG_1(swigCPtr, publicKey, privateKey);
    return ret;
  }

  public virtual void DisableSecurity() {
    RakNetPINVOKE.RakPeerInterface_DisableSecurity(swigCPtr);
  }

  public virtual void AddToSecurityExceptionList(string ip) {
    RakNetPINVOKE.RakPeerInterface_AddToSecurityExceptionList(swigCPtr, ip);
  }

  public virtual void RemoveFromSecurityExceptionList(string ip) {
    RakNetPINVOKE.RakPeerInterface_RemoveFromSecurityExceptionList(swigCPtr, ip);
  }

  public virtual bool IsInSecurityExceptionList(string ip) {
    bool ret = RakNetPINVOKE.RakPeerInterface_IsInSecurityExceptionList(swigCPtr, ip);
    return ret;
  }

  public virtual void SetMaximumIncomingConnections(ushort numberAllowed) {
    RakNetPINVOKE.RakPeerInterface_SetMaximumIncomingConnections(swigCPtr, numberAllowed);
  }

  public virtual uint GetMaximumIncomingConnections() {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetMaximumIncomingConnections(swigCPtr);
    return ret;
  }

  public virtual ushort NumberOfConnections() {
    ushort ret = RakNetPINVOKE.RakPeerInterface_NumberOfConnections(swigCPtr);
    return ret;
  }

  public virtual void SetIncomingPassword(string passwordData, int passwordDataLength) {
    RakNetPINVOKE.RakPeerInterface_SetIncomingPassword__SWIG_0(swigCPtr, passwordData, passwordDataLength);
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount, uint timeBetweenSendConnectionAttemptsMS, uint timeoutTime) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_0(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount, timeBetweenSendConnectionAttemptsMS, timeoutTime);
    return ret;
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount, uint timeBetweenSendConnectionAttemptsMS) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_1(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount, timeBetweenSendConnectionAttemptsMS);
    return ret;
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex, uint sendConnectionAttemptCount) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_2(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex, sendConnectionAttemptCount);
    return ret;
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey, uint connectionSocketIndex) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_3(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey), connectionSocketIndex);
    return ret;
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength, PublicKey publicKey) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_4(swigCPtr, host, remotePort, passwordData, passwordDataLength, PublicKey.getCPtr(publicKey));
    return ret;
  }

  public virtual ConnectionAttemptResult Connect(string host, ushort remotePort, string passwordData, int passwordDataLength) {
    ConnectionAttemptResult ret = (ConnectionAttemptResult)RakNetPINVOKE.RakPeerInterface_Connect__SWIG_5(swigCPtr, host, remotePort, passwordData, passwordDataLength);
    return ret;
  }

  public virtual void Shutdown(uint blockDuration, byte orderingChannel, PacketPriority disconnectionNotificationPriority) {
    RakNetPINVOKE.RakPeerInterface_Shutdown__SWIG_0(swigCPtr, blockDuration, orderingChannel, (int)disconnectionNotificationPriority);
  }

  public virtual void Shutdown(uint blockDuration, byte orderingChannel) {
    RakNetPINVOKE.RakPeerInterface_Shutdown__SWIG_1(swigCPtr, blockDuration, orderingChannel);
  }

  public virtual void Shutdown(uint blockDuration) {
    RakNetPINVOKE.RakPeerInterface_Shutdown__SWIG_2(swigCPtr, blockDuration);
  }

  public virtual bool IsActive() {
    bool ret = RakNetPINVOKE.RakPeerInterface_IsActive(swigCPtr);
    return ret;
  }

  public virtual uint GetNextSendReceipt() {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetNextSendReceipt(swigCPtr);
    return ret;
  }

  public virtual uint IncrementNextSendReceipt() {
    uint ret = RakNetPINVOKE.RakPeerInterface_IncrementNextSendReceipt(swigCPtr);
    return ret;
  }

  public virtual uint Send(string data, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast, uint forceReceiptNumber) {
    uint ret = RakNetPINVOKE.RakPeerInterface_Send__SWIG_0(swigCPtr, data, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast, forceReceiptNumber);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint Send(string data, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeerInterface_Send__SWIG_1(swigCPtr, data, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SendLoopback(string data, int length) {
    RakNetPINVOKE.RakPeerInterface_SendLoopback__SWIG_0(swigCPtr, data, length);
  }

  public virtual uint Send(BitStream bitStream, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast, uint forceReceiptNumber) {
    uint ret = RakNetPINVOKE.RakPeerInterface_Send__SWIG_2(swigCPtr, BitStream.getCPtr(bitStream), (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast, forceReceiptNumber);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint Send(BitStream bitStream, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeerInterface_Send__SWIG_3(swigCPtr, BitStream.getCPtr(bitStream), (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Packet Receive() {
    IntPtr cPtr = RakNetPINVOKE.RakPeerInterface_Receive(swigCPtr);
    Packet ret = (cPtr == IntPtr.Zero) ? null : new Packet(cPtr, false);
    return ret;
  }

  public virtual void DeallocatePacket(Packet packet) {
    RakNetPINVOKE.RakPeerInterface_DeallocatePacket(swigCPtr, Packet.getCPtr(packet));
  }

  public virtual uint GetMaximumNumberOfPeers() {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetMaximumNumberOfPeers(swigCPtr);
    return ret;
  }

  public virtual void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification, byte orderingChannel, PacketPriority disconnectionNotificationPriority) {
    RakNetPINVOKE.RakPeerInterface_CloseConnection__SWIG_0(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification, orderingChannel, (int)disconnectionNotificationPriority);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification, byte orderingChannel) {
    RakNetPINVOKE.RakPeerInterface_CloseConnection__SWIG_1(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification, orderingChannel);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CloseConnection(AddressOrGUID target, bool sendDisconnectionNotification) {
    RakNetPINVOKE.RakPeerInterface_CloseConnection__SWIG_2(swigCPtr, AddressOrGUID.getCPtr(target), sendDisconnectionNotification);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ConnectionState GetConnectionState(AddressOrGUID systemIdentifier) {
    ConnectionState ret = (ConnectionState)RakNetPINVOKE.RakPeerInterface_GetConnectionState(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void CancelConnectionAttempt(SystemAddress target) {
    RakNetPINVOKE.RakPeerInterface_CancelConnectionAttempt(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int GetIndexFromSystemAddress(SystemAddress systemAddress) {
    int ret = RakNetPINVOKE.RakPeerInterface_GetIndexFromSystemAddress(swigCPtr, SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SystemAddress GetSystemAddressFromIndex(uint index) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetSystemAddressFromIndex(swigCPtr, index), true);
    return ret;
  }

  public virtual RakNetGUID GetGUIDFromIndex(uint index) {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeerInterface_GetGUIDFromIndex(swigCPtr, index), true);
    return ret;
  }

  public virtual void GetSystemList(RakNetListSystemAddress addresses, RakNetListRakNetGUID guids) {
    RakNetPINVOKE.RakPeerInterface_GetSystemList(swigCPtr, RakNetListSystemAddress.getCPtr(addresses), RakNetListRakNetGUID.getCPtr(guids));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddToBanList(string IP, uint milliseconds) {
    RakNetPINVOKE.RakPeerInterface_AddToBanList__SWIG_0(swigCPtr, IP, milliseconds);
  }

  public virtual void AddToBanList(string IP) {
    RakNetPINVOKE.RakPeerInterface_AddToBanList__SWIG_1(swigCPtr, IP);
  }

  public virtual void RemoveFromBanList(string IP) {
    RakNetPINVOKE.RakPeerInterface_RemoveFromBanList(swigCPtr, IP);
  }

  public virtual void ClearBanList() {
    RakNetPINVOKE.RakPeerInterface_ClearBanList(swigCPtr);
  }

  public virtual bool IsBanned(string IP) {
    bool ret = RakNetPINVOKE.RakPeerInterface_IsBanned(swigCPtr, IP);
    return ret;
  }

  public virtual void SetLimitIPConnectionFrequency(bool b) {
    RakNetPINVOKE.RakPeerInterface_SetLimitIPConnectionFrequency(swigCPtr, b);
  }

  public virtual void Ping(SystemAddress target) {
    RakNetPINVOKE.RakPeerInterface_Ping__SWIG_0(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool Ping(string host, ushort remotePort, bool onlyReplyOnAcceptingConnections, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeerInterface_Ping__SWIG_1(swigCPtr, host, remotePort, onlyReplyOnAcceptingConnections, connectionSocketIndex);
    return ret;
  }

  public virtual bool Ping(string host, ushort remotePort, bool onlyReplyOnAcceptingConnections) {
    bool ret = RakNetPINVOKE.RakPeerInterface_Ping__SWIG_2(swigCPtr, host, remotePort, onlyReplyOnAcceptingConnections);
    return ret;
  }

  public virtual int GetAveragePing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeerInterface_GetAveragePing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetLastPing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeerInterface_GetLastPing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetLowestPing(AddressOrGUID systemIdentifier) {
    int ret = RakNetPINVOKE.RakPeerInterface_GetLowestPing(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetOccasionalPing(bool doPing) {
    RakNetPINVOKE.RakPeerInterface_SetOccasionalPing(swigCPtr, doPing);
  }

  public virtual ulong GetClockDifferential(AddressOrGUID systemIdentifier) {
    ulong ret = RakNetPINVOKE.RakPeerInterface_GetClockDifferential(swigCPtr, AddressOrGUID.getCPtr(systemIdentifier));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetOfflinePingResponse(string data, uint length) {
    RakNetPINVOKE.RakPeerInterface_SetOfflinePingResponse__SWIG_0(swigCPtr, data, length);
  }

  public virtual SystemAddress GetInternalID(SystemAddress systemAddress, int index) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetInternalID__SWIG_0(swigCPtr, SystemAddress.getCPtr(systemAddress), index), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SystemAddress GetInternalID(SystemAddress systemAddress) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetInternalID__SWIG_1(swigCPtr, SystemAddress.getCPtr(systemAddress)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SystemAddress GetInternalID() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetInternalID__SWIG_2(swigCPtr), true);
    return ret;
  }

  public virtual void SetInternalID(SystemAddress systemAddress, int index) {
    RakNetPINVOKE.RakPeerInterface_SetInternalID__SWIG_0(swigCPtr, SystemAddress.getCPtr(systemAddress), index);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetInternalID(SystemAddress systemAddress) {
    RakNetPINVOKE.RakPeerInterface_SetInternalID__SWIG_1(swigCPtr, SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SystemAddress GetExternalID(SystemAddress target) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetExternalID(swigCPtr, SystemAddress.getCPtr(target)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual RakNetGUID GetMyGUID() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeerInterface_GetMyGUID(swigCPtr), true);
    return ret;
  }

  public virtual SystemAddress GetMyBoundAddress(int socketIndex) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetMyBoundAddress__SWIG_0(swigCPtr, socketIndex), true);
    return ret;
  }

  public virtual SystemAddress GetMyBoundAddress() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetMyBoundAddress__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static ulong Get64BitUniqueRandomNumber() {
    ulong ret = RakNetPINVOKE.RakPeerInterface_Get64BitUniqueRandomNumber();
    return ret;
  }

  public virtual RakNetGUID GetGuidFromSystemAddress(SystemAddress input) {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakPeerInterface_GetGuidFromSystemAddress(swigCPtr, SystemAddress.getCPtr(input)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SystemAddress GetSystemAddressFromGuid(RakNetGUID input) {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.RakPeerInterface_GetSystemAddressFromGuid(swigCPtr, RakNetGUID.getCPtr(input)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetClientPublicKeyFromSystemAddress(SystemAddress input, string client_public_key) {
    bool ret = RakNetPINVOKE.RakPeerInterface_GetClientPublicKeyFromSystemAddress(swigCPtr, SystemAddress.getCPtr(input), client_public_key);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetTimeoutTime(uint timeMS, SystemAddress target) {
    RakNetPINVOKE.RakPeerInterface_SetTimeoutTime(swigCPtr, timeMS, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint GetTimeoutTime(SystemAddress target) {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetTimeoutTime(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetMTUSize(SystemAddress target) {
    int ret = RakNetPINVOKE.RakPeerInterface_GetMTUSize(swigCPtr, SystemAddress.getCPtr(target));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint GetNumberOfAddresses() {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetNumberOfAddresses(swigCPtr);
    return ret;
  }

  public virtual string GetLocalIP(uint index) {
    string ret = RakNetPINVOKE.RakPeerInterface_GetLocalIP(swigCPtr, index);
    return ret;
  }

  public virtual bool IsLocalIP(string ip) {
    bool ret = RakNetPINVOKE.RakPeerInterface_IsLocalIP(swigCPtr, ip);
    return ret;
  }

  public virtual void AllowConnectionResponseIPMigration(bool allow) {
    RakNetPINVOKE.RakPeerInterface_AllowConnectionResponseIPMigration(swigCPtr, allow);
  }

  public virtual bool AdvertiseSystem(string host, ushort remotePort, string data, int dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeerInterface_AdvertiseSystem__SWIG_0(swigCPtr, host, remotePort, data, dataLength, connectionSocketIndex);
    return ret;
  }

  public virtual bool AdvertiseSystem(string host, ushort remotePort, string data, int dataLength) {
    bool ret = RakNetPINVOKE.RakPeerInterface_AdvertiseSystem__SWIG_1(swigCPtr, host, remotePort, data, dataLength);
    return ret;
  }

  public virtual void SetSplitMessageProgressInterval(int interval) {
    RakNetPINVOKE.RakPeerInterface_SetSplitMessageProgressInterval(swigCPtr, interval);
  }

  public virtual int GetSplitMessageProgressInterval() {
    int ret = RakNetPINVOKE.RakPeerInterface_GetSplitMessageProgressInterval(swigCPtr);
    return ret;
  }

  public virtual void SetUnreliableTimeout(uint timeoutMS) {
    RakNetPINVOKE.RakPeerInterface_SetUnreliableTimeout(swigCPtr, timeoutMS);
  }

  public virtual void SendTTL(string host, ushort remotePort, int ttl, uint connectionSocketIndex) {
    RakNetPINVOKE.RakPeerInterface_SendTTL__SWIG_0(swigCPtr, host, remotePort, ttl, connectionSocketIndex);
  }

  public virtual void SendTTL(string host, ushort remotePort, int ttl) {
    RakNetPINVOKE.RakPeerInterface_SendTTL__SWIG_1(swigCPtr, host, remotePort, ttl);
  }

  public virtual void AttachPlugin(PluginInterface2 plugin) {
    RakNetPINVOKE.RakPeerInterface_AttachPlugin(swigCPtr, PluginInterface2.getCPtr(plugin));
  }

  public virtual void DetachPlugin(PluginInterface2 messageHandler) {
    RakNetPINVOKE.RakPeerInterface_DetachPlugin(swigCPtr, PluginInterface2.getCPtr(messageHandler));
  }

  public virtual void PushBackPacket(Packet packet, bool pushAtHead) {
    RakNetPINVOKE.RakPeerInterface_PushBackPacket(swigCPtr, Packet.getCPtr(packet), pushAtHead);
  }

  public virtual void ChangeSystemAddress(RakNetGUID guid, SystemAddress systemAddress) {
    RakNetPINVOKE.RakPeerInterface_ChangeSystemAddress(swigCPtr, RakNetGUID.getCPtr(guid), SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Packet AllocatePacket(uint dataSize) {
    IntPtr cPtr = RakNetPINVOKE.RakPeerInterface_AllocatePacket(swigCPtr, dataSize);
    Packet ret = (cPtr == IntPtr.Zero) ? null : new Packet(cPtr, false);
    return ret;
  }

  public virtual void GetSockets(SWIGTYPE_p_DataStructures__ListT_RakNetSocket2_p_t sockets) {
    RakNetPINVOKE.RakPeerInterface_GetSockets(swigCPtr, SWIGTYPE_p_DataStructures__ListT_RakNetSocket2_p_t.getCPtr(sockets));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void WriteOutOfBandHeader(BitStream bitStream) {
    RakNetPINVOKE.RakPeerInterface_WriteOutOfBandHeader(swigCPtr, BitStream.getCPtr(bitStream));
  }

  public virtual void ApplyNetworkSimulator(float packetloss, ushort minExtraPing, ushort extraPingVariance) {
    RakNetPINVOKE.RakPeerInterface_ApplyNetworkSimulator(swigCPtr, packetloss, minExtraPing, extraPingVariance);
  }

  public virtual void SetPerConnectionOutgoingBandwidthLimit(uint maxBitsPerSecond) {
    RakNetPINVOKE.RakPeerInterface_SetPerConnectionOutgoingBandwidthLimit(swigCPtr, maxBitsPerSecond);
  }

  public virtual bool IsNetworkSimulatorActive() {
    bool ret = RakNetPINVOKE.RakPeerInterface_IsNetworkSimulatorActive(swigCPtr);
    return ret;
  }

  public virtual RakNetStatistics GetStatistics(SystemAddress systemAddress, RakNetStatistics rns) {
    IntPtr cPtr = RakNetPINVOKE.RakPeerInterface_GetStatistics__SWIG_0(swigCPtr, SystemAddress.getCPtr(systemAddress), RakNetStatistics.getCPtr(rns));
    RakNetStatistics ret = (cPtr == IntPtr.Zero) ? null : new RakNetStatistics(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual RakNetStatistics GetStatistics(SystemAddress systemAddress) {
    IntPtr cPtr = RakNetPINVOKE.RakPeerInterface_GetStatistics__SWIG_1(swigCPtr, SystemAddress.getCPtr(systemAddress));
    RakNetStatistics ret = (cPtr == IntPtr.Zero) ? null : new RakNetStatistics(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetStatistics(uint index, RakNetStatistics rns) {
    bool ret = RakNetPINVOKE.RakPeerInterface_GetStatistics__SWIG_2(swigCPtr, index, RakNetStatistics.getCPtr(rns));
    return ret;
  }

  public virtual uint GetReceiveBufferSize() {
    uint ret = RakNetPINVOKE.RakPeerInterface_GetReceiveBufferSize(swigCPtr);
    return ret;
  }

  public virtual bool RunUpdateCycle(BitStream updateBitStream) {
    bool ret = RakNetPINVOKE.RakPeerInterface_RunUpdateCycle(swigCPtr, BitStream.getCPtr(updateBitStream));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool SendOutOfBand(string host, ushort remotePort, string data, uint dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeerInterface_SendOutOfBand__SWIG_0(swigCPtr, host, remotePort, data, dataLength, connectionSocketIndex);
    return ret;
  }

  public virtual bool SendOutOfBand(string host, ushort remotePort, string data, uint dataLength) {
    bool ret = RakNetPINVOKE.RakPeerInterface_SendOutOfBand__SWIG_1(swigCPtr, host, remotePort, data, dataLength);
    return ret;
  }

  public uint Send(byte[] inByteArray, int length, PacketPriority priority, PacketReliability reliability, char orderingChannel, AddressOrGUID systemIdentifier, bool broadcast) {
    uint ret = RakNetPINVOKE.RakPeerInterface_Send__SWIG_4(swigCPtr, inByteArray, length, (int)priority, (int)reliability, orderingChannel, AddressOrGUID.getCPtr(systemIdentifier), broadcast);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SendLoopback(byte[] inByteArray, int length) {
    RakNetPINVOKE.RakPeerInterface_SendLoopback__SWIG_1(swigCPtr, inByteArray, length);
  }

  public void SetOfflinePingResponse(byte[] inByteArray, uint length) {
    RakNetPINVOKE.RakPeerInterface_SetOfflinePingResponse__SWIG_1(swigCPtr, inByteArray, length);
  }

  public bool AdvertiseSystem(string host, ushort remotePort, byte[] inByteArray, int dataLength, uint connectionSocketIndex) {
    bool ret = RakNetPINVOKE.RakPeerInterface_AdvertiseSystem__SWIG_2(swigCPtr, host, remotePort, inByteArray, dataLength, connectionSocketIndex);
    return ret;
  }

  public bool AdvertiseSystem(string host, ushort remotePort, byte[] inByteArray, int dataLength) {
    bool ret = RakNetPINVOKE.RakPeerInterface_AdvertiseSystem__SWIG_3(swigCPtr, host, remotePort, inByteArray, dataLength);
    return ret;
  }

  private string CSharpGetIncomingPasswordHelper(string passwordData, ref int passwordDataLength) {
    string ret = RakNetPINVOKE.RakPeerInterface_CSharpGetIncomingPasswordHelper(swigCPtr, passwordData, ref passwordDataLength);
    return ret;
  }

  public void SetIncomingPassword(byte[] passwordDataByteArray, int passwordDataLength) {
    RakNetPINVOKE.RakPeerInterface_SetIncomingPassword__SWIG_1(swigCPtr, passwordDataByteArray, passwordDataLength);
  }

  public void GetIncomingPassword(byte[] passwordDataByteArray, ref int passwordDataLength) {
    RakNetPINVOKE.RakPeerInterface_GetIncomingPassword(swigCPtr, passwordDataByteArray, ref passwordDataLength);
  }

  private void CSharpGetOfflinePingResponseHelper(byte[] inOutByteArray, out uint outLength) {
    RakNetPINVOKE.RakPeerInterface_CSharpGetOfflinePingResponseHelper(swigCPtr, inOutByteArray, out outLength);
  }

  public bool GetConnectionList(RakNetListSystemAddress remoteSystems, ref ushort numberOfSystems) {
    bool ret = RakNetPINVOKE.RakPeerInterface_GetConnectionList(swigCPtr, RakNetListSystemAddress.getCPtr(remoteSystems), ref numberOfSystems);
    return ret;
  }

}

}
