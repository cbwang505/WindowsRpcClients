//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\rpcepmap.dll
// Interface ID: e1af8308-5d1f-11c9-91a4-08002b14a0fa
// Interface Version: 3.0



namespace rpc_e1af8308_5d1f_11c9_91a4_08002b14a0fa_3_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
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
        public void Write_5(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_6(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_7(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 6);
        }
        public void Write_8(Struct_2[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_2>(p0, p1, p2);
        }
        public void Write_9(Struct_3[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_3>(p0, p1, p2);
        }
        public void Write_10(Struct_3[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_3>(p0, p1, p2);
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
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
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
        public byte[] Read_5()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_6()
        {
            return ReadConformantArray<int>();
        }
        public sbyte[] Read_7()
        {
            return ReadFixedPrimitiveArray<sbyte>(6);
        }
        public Struct_2[] Read_8()
        {
            return ReadConformantVaryingStructArray<Struct_2>();
        }
        public Struct_3[] Read_9()
        {
            return ReadConformantVaryingStructArray<Struct_3>();
        }
        public Struct_3[] Read_10()
        {
            return ReadConformantVaryingStructArray<Struct_3>();
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
            m.WriteGuid(Member0);
            m.WriteInt16(Member10);
            m.WriteInt16(Member12);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt16();
            Member12 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public short Member10;
        public short Member12;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(System.Guid Member0, short Member10, short Member12)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member12 = Member12;
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
            m.WriteGuid(Member0);
            m.WriteEmbeddedPointer<Struct_3>(Member10, new System.Action<Struct_3>(m.Write_2));
            m.WriteVaryingAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member18, "Member18"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadEmbeddedPointer<Struct_3>(new System.Func<Struct_3>(u.Read_2), true);
            Member18 = u.ReadVaryingAnsiString();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_3> Member10;
        public string Member18;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(System.Guid Member0, System.Nullable<Struct_3> Member10, string Member18)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_5();
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
        public byte[] Member4;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member4 = new byte[0];
            return ret;
        }
        public Struct_3(int Member0, byte[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteByte(Member0);
            m.WriteByte(Member1);
            m.Write_4(Member2);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member1);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadByte();
            Member1 = u.ReadByte();
            Member2 = u.Read_4();
            Member8 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public byte Member0;
        public byte Member1;
        public Struct_5 Member2;
        public int[] Member8;
        public static Struct_4 CreateDefault()
        {
            Struct_4 ret = new Struct_4();
            ret.Member8 = new int[0];
            return ret;
        }
        public Struct_4(byte Member0, byte Member1, Struct_5 Member2, int[] Member8)
        {
            this.Member0 = Member0;
            this.Member1 = Member1;
            this.Member2 = Member2;
            this.Member8 = Member8;
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
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_7();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member0 = new sbyte[6];
            return ret;
        }
        public Struct_5(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e1af8308-5d1f-11c9-91a4-08002b14a0fa", 3, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public void ept_delete()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
        }
        public void ept_delete_1()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(1, m);
        }
        public void ept_lookup(int p0, System.Nullable<System.Guid> p1, System.Nullable<Struct_1> p2, int p3, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p4, int p5, out int p6, out Struct_2[] p7, out int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<Struct_1>(m.Write_0));
            m.WriteInt32(p3);
            m.WriteContextHandle(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadContextHandle();
            p6 = u.ReadInt32();
            p7 = u.Read_8();
            p8 = u.ReadInt32();
        }
        // async
        public void ept_map(System.Nullable<System.Guid> p0, System.Nullable<Struct_3> p1, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, int p3, out int p4, out Struct_3[] p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<Struct_3>(m.Write_2));
            m.WriteContextHandle(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadContextHandle();
            p4 = u.ReadInt32();
            p5 = u.Read_9();
            p6 = u.ReadInt32();
        }
        public void ept_lookup_handle_free(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            p1 = u.ReadInt32();
        }
        public void ept_delete_5()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
        }
        public void ept_delete_6()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
        }
        // async
        public void ept_map_auth(System.Guid p0, Struct_3 p1, System.Nullable<Struct_4> p2, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p3, int p4, out int p5, out Struct_3[] p6, out int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_2(p1);
            m.WriteReferent(p2, new System.Action<Struct_4>(m.Write_3));
            m.WriteContextHandle(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(7, m);
            p3 = u.ReadContextHandle();
            p5 = u.ReadInt32();
            p6 = u.Read_10();
            p7 = u.ReadInt32();
        }
        // async
        public void ept_map_auth_async(System.Guid p0, Struct_3 p1, System.Nullable<Struct_4> p2, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p3, int p4, out int p5, out Struct_3[] p6, out int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_2(p1);
            m.WriteReferent(p2, new System.Action<Struct_4>(m.Write_3));
            m.WriteContextHandle(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(8, m);
            p3 = u.ReadContextHandle();
            p5 = u.ReadInt32();
            p6 = u.Read_10();
            p7 = u.ReadInt32();
        }
    }
    #endregion
}

