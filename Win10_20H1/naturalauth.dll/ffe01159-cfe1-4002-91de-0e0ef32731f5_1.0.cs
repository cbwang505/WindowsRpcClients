//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\naturalauth.dll
// Interface ID: ffe01159-cfe1-4002-91de-0e0ef32731f5
// Interface Version: 1.0



namespace rpc_ffe01159_cfe1_4002_91de_0e0ef32731f5_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
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
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("ffe01159-cfe1-4002-91de-0e0ef32731f5", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int CDFRPCUpdatePresenceState(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int CDFRPCRegisterDevice(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int CDFRPCUnregisterDevice(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

