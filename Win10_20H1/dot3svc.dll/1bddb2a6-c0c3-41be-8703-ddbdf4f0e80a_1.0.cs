//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\dot3svc.dll
// Interface ID: 1bddb2a6-c0c3-41be-8703-ddbdf4f0e80a
// Interface Version: 1.0



namespace rpc_1bddb2a6_c0c3_41be_8703_ddbdf4f0e80a_1_0
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
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(NtApiDotNet.Ndr.Marshal.NdrUnsupported p0)
        {
            WriteUnsupported(p0, "FC_BOGUS_ARRAY -  struct Struct_1[]");
        }
        public void Write_10(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 64);
        }
        public void Write_12(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_13(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_14(string p0)
        {
            WriteFixedString(p0, 1024);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_16(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_17(Struct_9[] p0, long p1)
        {
            WriteConformantStructArray<Struct_9>(p0, p1);
        }
        public void Write_18(Struct_9[] p0, long p1)
        {
            WriteConformantStructArray<Struct_9>(p0, p1);
        }
        public void Write_19(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_20(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Read_9()
        {
            return ReadUnsupported("FC_BOGUS_ARRAY -  struct Struct_1[]");
        }
        public string Read_10()
        {
            return ReadFixedString(256);
        }
        public string Read_11()
        {
            return ReadFixedString(64);
        }
        public sbyte[] Read_12()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_13()
        {
            return ReadConformantArray<sbyte>();
        }
        public string Read_14()
        {
            return ReadFixedString(1024);
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_16()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_9[] Read_17()
        {
            return ReadConformantStructArray<Struct_9>();
        }
        public Struct_9[] Read_18()
        {
            return ReadConformantStructArray<Struct_9>();
        }
        public sbyte[] Read_19()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_20()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.Read_9();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, NtApiDotNet.Ndr.Marshal.NdrUnsupported Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
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
            m.WriteGuid(Member0);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member10, "Member10"));
            m.WriteEnum16(Member210);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.Read_10();
            Member210 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public string Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member210;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member10 = new string('\0', 256);
            return ret;
        }
        public Struct_1(System.Guid Member0, string Member10, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member210)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member210 = Member210;
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
            m.WriteEnum16(Member0);
            m.WriteEnum16(Member4);
            m.WriteEnum16(Member8);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadEnum16();
            Member8 = u.ReadEnum16();
            MemberC = u.Read_11();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8;
        public string MemberC;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.MemberC = new string('\0', 64);
            return ret;
        }
        public Struct_3(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8, string MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteGuid(Member8);
            m.WriteInt32(Member18);
            m.WriteEmbeddedPointer<sbyte[], long>(Member20, new System.Action<sbyte[], long>(m.Write_12), Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadGuid();
            Member18 = u.ReadInt32();
            Member20 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_12), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public System.Guid Member8;
        public int Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member20;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, int Member4, System.Guid Member8, int Member18, sbyte[] Member20)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member18 = Member18;
            this.Member20 = Member20;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_13), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_13), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(int Member0, sbyte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.Write_4(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.Read_4();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public Struct_5 Member8;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, int Member4, Struct_5 Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_7(Member0);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_7();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_8 Member0;
        public int MemberC;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(Struct_8 Member0, int MemberC)
        {
            this.Member0 = Member0;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteSByte(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public sbyte Member0;
        public int Member4;
        public int Member8;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(sbyte Member0, int Member4, int Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member20C, "Member20C"));
            m.WriteInt32(MemberA0C);
            m.WriteInt32(MemberA10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.Read_10();
            Member20C = u.Read_14();
            MemberA0C = u.ReadInt32();
            MemberA10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public int Member4;
        public int Member8;
        public string MemberC;
        public string Member20C;
        public int MemberA0C;
        public int MemberA10;
        public static Struct_9 CreateDefault()
        {
            Struct_9 ret = new Struct_9();
            ret.MemberC = new string('\0', 256);
            ret.Member20C = new string('\0', 1024);
            return ret;
        }
        public Struct_9(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, int Member4, int Member8, string MemberC, string Member20C, int MemberA0C, int MemberA10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member20C = Member20C;
            this.MemberA0C = MemberA0C;
            this.MemberA10 = MemberA10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("1bddb2a6-c0c3-41be-8703-ddbdf4f0e80a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcOpenHandle(char p0, int p1, ref int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadInt32();
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcCloseHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcEnumInterfaces(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int RpcSetInterface(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, int p2, int p3, sbyte[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int RpcGetInterfaceState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out Struct_3 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            p2 = u.Read_2();
            return u.ReadInt32();
        }
        public int RpcReConnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int RpcRegisterNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(6, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        // async
        public int RpcAsyncGetNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_4> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadReferentValue<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            return u.ReadInt32();
        }
        public int RpcSetProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<System.Guid> p1, string p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(8, m);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcGetProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<System.Guid> p1, int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(9, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RpcGetCurrentProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<System.Guid> p1, out int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(10, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RpcDeleteProfile(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<System.Guid> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int RpcUIResponse(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, Struct_5 p2, Struct_6 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.Write_4(p2);
            m.Write_5(p3);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int RpcQueryUIRequest(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out Struct_5 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(13, m);
            p2 = u.Read_4();
            return u.ReadInt32();
        }
        public int RpcSetProfileEapUserData(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<System.Guid> p1, Struct_7 p2, int p3, int p4, sbyte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.Write_6(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<sbyte[], long>(m.Write_16), p4);
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        // async
        public int RpcAsyncDoPlap(char p0, System.Guid p1, string p2, int p3, Struct_9[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteInt32(p3);
            m.Write_17(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int RpcQueryPlapCredentials(char p0, out int p1, out Struct_9[] p2, out string p3, out System.Guid p4, out int p5, out int p6, out int p7, out int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_9[]>(new System.Func<Struct_9[]>(u.Read_18), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p4 = u.ReadGuid();
            p5 = u.ReadInt32();
            p6 = u.ReadInt32();
            p7 = u.ReadInt32();
            p8 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcCancelPlap(char p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadInt32();
        }
        public int RpcGetProfileEapUserDataInfo(char p0, System.Nullable<System.Guid> p1, int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(18, m);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSetAutoConfigParameter(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, sbyte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_19(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int RpcQueryAutoConfigParameter(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2, out sbyte[] p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(20, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_20), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

