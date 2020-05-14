//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\winhttp.dll
// Interface ID: 824d8d77-a27f-4915-a536-36e9283dce29
// Interface Version: 5.1



namespace rpc_824d8d77_a27f_4915_a536_36e9283dce29_5_1
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public byte[] Read_0()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("824d8d77-a27f-4915-a536-36e9283dce29", 5, 1)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint s_PacWorkerCallbackInitSessionRpc(int p0, byte[] p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackCloseSessionRpc(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackIsResolvableRpc(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackIsResolvableExRpc(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackIsInNetRpc(string p0, string p1, string p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackIsInNetExRpc(string p0, string p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackDnsResolveRpc(string p0, ref string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackDnsResolveExRpc(string p0, ref string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackMyIpAddressRpc(ref string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(8, m);
            p0 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackMyIpAddressExRpc(ref string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
        public uint s_PacWorkerCallbackSortIpAddressListRpc(string p0, ref string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
    }
    #endregion
}

