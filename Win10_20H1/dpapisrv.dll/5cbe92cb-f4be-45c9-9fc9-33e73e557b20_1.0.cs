//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\dpapisrv.dll
// Interface ID: 5cbe92cb-f4be-45c9-9fc9-33e73e557b20
// Interface Version: 1.0



namespace rpc_5cbe92cb_f4be_45c9_9fc9_33e73e557b20_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_2(byte[] p0, long p1)
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
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("5cbe92cb-f4be-45c9-9fc9-33e73e557b20", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_SSRecoverQueryStatus(byte[] p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<byte[], long>(m.Write_0), p1);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_SSRecoverImportRecoveryKey(byte[] p0, int p1, byte[] p2, int p3, byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<byte[], long>(m.Write_0), p1);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<byte[], long>(m.Write_1), p3);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_2), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int s_SSRecoverPassword(byte[] p0, int p1, byte[] p2, int p3, byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<byte[], long>(m.Write_0), p1);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<byte[], long>(m.Write_1), p3);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_2), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

