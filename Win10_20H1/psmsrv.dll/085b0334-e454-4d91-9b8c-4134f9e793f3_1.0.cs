//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\psmsrv.dll
// Interface ID: 085b0334-e454-4d91-9b8c-4134f9e793f3
// Interface Version: 1.0



namespace rpc_085b0334_e454_4d91_9b8c_4134f9e793f3_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
        public Struct_0[] Read_5()
        {
            return ReadConformantStructArray<Struct_0>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.Write_1(Member10);
            m.WriteInt32(Member40);
            m.WriteEmbeddedPointer<byte[], long>(Member48, new System.Action<byte[], long>(m.Write_3), Member40);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.Read_1();
            Member40 = u.ReadInt32();
            Member48 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public Struct_1 Member10;
        public int Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member48;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, string Member8, Struct_1 Member10, int Member40, byte[] Member48)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member40 = Member40;
            this.Member48 = Member48;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteInt32(Member4);
            m.WriteUInt3264(Member8);
            m.WriteUInt3264(Member10);
            m.WriteUInt3264(Member18);
            m.WriteInt64(Member20);
            m.WriteInt64(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadInt32();
            Member8 = u.ReadUInt3264();
            Member10 = u.ReadUInt3264();
            Member18 = u.ReadUInt3264();
            Member20 = u.ReadInt64();
            Member28 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member10;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18;
        public long Member20;
        public long Member28;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, int Member4, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member10, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18, long Member20, long Member28)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
            m.WriteInt64(Member8);
            m.WriteInt64(Member10);
            m.WriteInt64(Member18);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
            m.WriteInt32(Member28);
            m.WriteInt32(Member2C);
            m.WriteInt32(Member30);
            m.WriteInt32(Member34);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt64();
            Member18 = u.ReadInt64();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
            Member28 = u.ReadInt32();
            Member2C = u.ReadInt32();
            Member30 = u.ReadInt32();
            Member34 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public long Member8;
        public long Member10;
        public long Member18;
        public int Member20;
        public int Member24;
        public int Member28;
        public int Member2C;
        public int Member30;
        public int Member34;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(long Member0, long Member8, long Member10, long Member18, int Member20, int Member24, int Member28, int Member2C, int Member30, int Member34)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member2C = Member2C;
            this.Member30 = Member30;
            this.Member34 = Member34;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("085b0334-e454-4d91-9b8c-4134f9e793f3", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PsmSrvOpenManagementChannel(int p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            p2 = u.ReadUInt3264();
            return u.ReadInt32();
        }
        public int PsmSrvSetApplicationState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, NtApiDotNet.Ndr.Marshal.NdrEnum16 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteEnum16(p5);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int PsmSrvSetApplicationPriority(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, NtApiDotNet.Ndr.Marshal.NdrEnum16 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteEnum16(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int PsmSrvReleaseCacheEntry(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int PsmSrvAcquireCachedEntries(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadReferent<Struct_0[]>(new System.Func<Struct_0[]>(u.Read_5), false);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationSwapState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            _Unmarshal_Helper u = SendReceive(5, m);
            p5 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int PsmSrvCloseActivationChannel(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PsmSrvSetApplicationProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, int p5, System.Nullable<int> p6, System.Nullable<long> p7, System.Nullable<long> p8, System.Nullable<long> p9, System.Nullable<NtApiDotNet.Ndr.Marshal.NdrEnum16> p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p7, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p8, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p9, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p10, new System.Action<NtApiDotNet.Ndr.Marshal.NdrEnum16>(m.WriteEnum16));
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, int p5, ref System.Nullable<int> p6, ref System.Nullable<long> p7, ref System.Nullable<long> p8, ref System.Nullable<long> p9, ref System.Nullable<NtApiDotNet.Ndr.Marshal.NdrEnum16> p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p7, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p8, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p9, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p10, new System.Action<NtApiDotNet.Ndr.Marshal.NdrEnum16>(m.WriteEnum16));
            _Unmarshal_Helper u = SendReceive(8, m);
            p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p7 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            p8 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            p9 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            p10 = u.ReadReferentValue<NtApiDotNet.Ndr.Marshal.NdrEnum16>(new System.Func<NtApiDotNet.Ndr.Marshal.NdrEnum16>(u.ReadEnum16), false);
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationResourceUsage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, out Struct_2 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            _Unmarshal_Helper u = SendReceive(9, m);
            p5 = u.Read_2();
            return u.ReadInt32();
        }
        public int PsmSrvQueryMemoryUsage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, int p5, ref System.Nullable<long> p6, ref System.Nullable<long> p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p7, new System.Action<long>(m.WriteInt64));
            _Unmarshal_Helper u = SendReceive(10, m);
            p6 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            p7 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            return u.ReadInt32();
        }
        public int PsmSrvResetMaxMemoryUsage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, int p5, long p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteInt32(p5);
            m.WriteInt64(p6);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int PsmSrvQuerySharedCommit(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, string p4, int p5, ref System.Nullable<long> p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<long>(m.WriteInt64));
            _Unmarshal_Helper u = SendReceive(12, m);
            p6 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

