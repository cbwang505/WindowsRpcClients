//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\bisrv.dll
// Interface ID: 20c40295-8dba-48e6-aebf-3e78ef3bb144
// Interface Version: 2.0



namespace rpc_20c40295_8dba_48e6_aebf_3e78ef3bb144_2_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
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
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
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
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt3264(Member0);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public int Member8;
        public int MemberC;
        public int Member10;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, int Member8, int MemberC, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("20c40295-8dba-48e6-aebf-3e78ef3bb144", 2, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int SrvOdbPtCreateSession(string p0, int p1, out int p2, out long p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadInt32();
            p3 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int SrvOdbPtCompleteSession(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int SrvOdbPtLaunchBackgroundTask(int p0, byte[] p1, int p2, string p3, string p4, System.Nullable<System.Guid> p5, byte[] p6, int p7, System.Nullable<Struct_1> p8, System.Nullable<System.Guid> p9, out System.Guid p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<byte[], long>(m.Write_1), p0);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteReferent(p5, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p6, new System.Action<byte[], long>(m.Write_2), p7);
            m.WriteInt32(p7);
            m.WriteReferent(p8, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p9, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(2, m);
            p10 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int SrvOdbPtCancelBackgroundTask(int p0, System.Guid p1, sbyte p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            m.WriteSByte(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

