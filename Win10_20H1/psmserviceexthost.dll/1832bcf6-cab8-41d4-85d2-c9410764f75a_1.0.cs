//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\psmserviceexthost.dll
// Interface ID: 1832bcf6-cab8-41d4-85d2-c9410764f75a
// Interface Version: 1.0



namespace rpc_1832bcf6_cab8_41d4_85d2_c9410764f75a_1_0
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
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_5(long[] p0)
        {
            WriteFixedPrimitiveArray<long>(p0, 2);
        }
        public void Write_6(byte[] p0, long p1)
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
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public int[] Read_4()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public long[] Read_5()
        {
            return ReadFixedPrimitiveArray<long>(2);
        }
        public byte[] Read_6()
        {
            return ReadConformantArray<byte>();
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
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_4();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_0(int[] Member0)
        {
            this.Member0 = Member0;
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
            m.Write_2(Member0);
            m.WriteInt32(Member20);
            m.WriteByte(Member24);
            m.Write_3(Member28);
            m.WriteInt16(Member60);
            m.WriteByte(Member62);
            m.WriteInt32(Member64);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_2();
            Member20 = u.ReadInt32();
            Member24 = u.ReadByte();
            Member28 = u.Read_3();
            Member60 = u.ReadInt16();
            Member62 = u.ReadByte();
            Member64 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_2 Member0;
        public int Member20;
        public byte Member24;
        public Struct_3 Member28;
        public short Member60;
        public byte Member62;
        public int Member64;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(Struct_2 Member0, int Member20, byte Member24, Struct_3 Member28, short Member60, byte Member62, int Member64)
        {
            this.Member0 = Member0;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member60 = Member60;
            this.Member62 = Member62;
            this.Member64 = Member64;
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
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt32(Member10);
            m.WriteInt64(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_5();
            Member10 = u.ReadInt32();
            Member18 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long[] Member0;
        public int Member10;
        public long Member18;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member0 = new long[2];
            return ret;
        }
        public Struct_2(long[] Member0, int Member10, long Member18)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
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
            m.WriteInt64(Member20);
            m.WriteInt64(Member28);
            m.WriteInt32(Member30);
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
            Member20 = u.ReadInt64();
            Member28 = u.ReadInt64();
            Member30 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public long Member8;
        public long Member10;
        public long Member18;
        public long Member20;
        public long Member28;
        public int Member30;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(long Member0, long Member8, long Member10, long Member18, long Member20, long Member28, int Member30)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("1832bcf6-cab8-41d4-85d2-c9410764f75a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint RmCoreRpcSrvConnectToRmServer(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            p1 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvDisconnectFromRmServer(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvRegisterActivityHostCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, out long p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadInt64();
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvUnregisterActivityHostCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvAcquireResourceSet(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_1 p1, long p2, string p3, byte[] p4, int p5, int p6, int p7, long p8, int p9, out long p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_1(p1);
            m.WriteInt64(p2);
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_6), p5);
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            m.WriteInt64(p8);
            m.WriteInt32(p9);
            _Unmarshal_Helper u = SendReceive(4, m);
            p10 = u.ReadInt64();
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvApplyResourceSet(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvReleaseResourceSet(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadUInt32();
        }
        public uint CrmRpcSrvActivityRenew(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, Struct_3 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.Write_3(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
        public uint RmCoreRpcSrvQueryHostMemoryLimitValues(long p0, out long p1, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadInt64();
            p2 = u.ReadEnum16();
            return u.ReadUInt32();
        }
    }
    #endregion
}

