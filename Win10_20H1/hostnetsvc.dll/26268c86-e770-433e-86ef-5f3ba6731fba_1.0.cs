//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\hostnetsvc.dll
// Interface ID: 26268c86-e770-433e-86ef-5f3ba6731fba
// Interface Version: 1.0



namespace rpc_26268c86_e770_433e_86ef_5f3ba6731fba_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(NtApiDotNet.NtEvent p0)
        {
            WriteSystemHandle<NtApiDotNet.NtEvent>(p0);
        }
        public void Write_1(NtApiDotNet.NtProcess p0)
        {
            WriteSystemHandle<NtApiDotNet.NtProcess>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public NtApiDotNet.NtEvent Read_0()
        {
            return ReadSystemHandle<NtApiDotNet.NtEvent>();
        }
        public NtApiDotNet.NtProcess Read_1()
        {
            return ReadSystemHandle<NtApiDotNet.NtProcess>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("26268c86-e770-433e-86ef-5f3ba6731fba", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int HnsRpc_EnumerateNetworks(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateNetwork(System.Guid p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenNetwork(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifyNetwork(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryNetworkProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(4, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteNetwork(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_RegisterNetworkNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtEvent p1, out NtApiDotNet.NtProcess p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.Read_0();
            p2 = u.Read_1();
            return u.ReadInt32();
        }
        public int HnsRpc_UnregisterGuestNetworkServiceNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryGuestNetworkServiceNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_EnumerateNamespaces(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateNamespace(System.Guid p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(11, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenNamespace(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifyNamespace(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(13, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryNamespaceProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(14, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteNamespace(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService_16(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_EnumerateEndpoints(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(17, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateEndpoint(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, string p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3, out string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(18, m);
            p3 = u.ReadContextHandle();
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenEndpoint(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(19, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifyEndpoint(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(20, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryEndpointProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(21, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteEndpoint(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(22, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseEndpoint(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(23, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_EnumerateLoadBalancers(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(24, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateLoadBalancer(System.Guid p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(25, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenLoadBalancer(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(26, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifyLoadBalancer(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(27, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryLoadBalancerProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(28, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteLoadBalancer(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(29, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService_30(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(30, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_EnumerateSdnRoutes(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(31, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateSdnRoute(System.Guid p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(32, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenLoadBalancer_33(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(33, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifySdnRoute(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(34, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QuerySdnRouteProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(35, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteLoadBalancer_36(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(36, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService_37(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(37, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_OpenService(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(38, m);
            p0 = u.ReadContextHandle();
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_RegisterServiceNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtEvent p1, out NtApiDotNet.NtProcess p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(39, m);
            p1 = u.Read_0();
            p2 = u.Read_1();
            return u.ReadInt32();
        }
        public int HnsRpc_UnregisterGuestNetworkServiceNotifications_40(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(40, m);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryGuestNetworkServiceNotification_41(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(41, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService_42(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(42, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HnsRpc_EnumerateGuestNetworkServices(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(43, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CreateGuestNetworkService(System.Guid p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(44, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_OpenGuestNetworkService(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(45, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_ModifyGuestNetworkService(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(46, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryGuestNetworkServiceProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(47, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_DeleteGuestNetworkService(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(48, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_RegisterGuestNetworkServiceNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtEvent p1, out NtApiDotNet.NtProcess p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(49, m);
            p1 = u.Read_0();
            p2 = u.Read_1();
            return u.ReadInt32();
        }
        public int HnsRpc_UnregisterGuestNetworkServiceNotifications_50(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(50, m);
            return u.ReadInt32();
        }
        public int HnsRpc_QueryGuestNetworkServiceNotification_51(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(51, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HnsRpc_CloseGuestNetworkService_52(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(52, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
    }
    #endregion
}

