//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\moshost.dll
// Interface ID: 91fd044b-902f-42c7-a945-6861bcf9309c
// Interface Version: 0.0



namespace rpc_91fd044b_902f_42c7_a945_6861bcf9309c_0_0
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
        public void Write_4(string p0)
        {
            WriteFixedString(p0, 260);
        }
        public void Write_5(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_6(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
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
        public string Read_4()
        {
            return ReadFixedString(260);
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
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
            m.WriteEnum16(Member214);
            m.Write_1(Member218);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.Read_4();
            Member214 = u.ReadEnum16();
            Member218 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public string MemberC;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214;
        public Struct_1 Member218;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.MemberC = new string('\0', 260);
            return ret;
        }
        public Struct_0(int Member0, int Member4, int Member8, string MemberC, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214, Struct_1 Member218)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member214 = Member214;
            this.Member218 = Member218;
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
            m.WriteInt32(Member0);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"));
            m.WriteInt32(Member20C);
            m.WriteEnum16(Member210);
            m.WriteEnum16(Member214);
            m.WriteInt32(Member218);
            m.WriteEnum16(Member21C);
            m.WriteEnum16(Member220);
            m.WriteGuid(Member224);
            m.WriteInt32(Member234);
            m.WriteInt64(Member238);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member240, "Member240"));
            m.WriteInt32(Member448);
            m.WriteInt32(Member44C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_4();
            Member20C = u.ReadInt32();
            Member210 = u.ReadEnum16();
            Member214 = u.ReadEnum16();
            Member218 = u.ReadInt32();
            Member21C = u.ReadEnum16();
            Member220 = u.ReadEnum16();
            Member224 = u.ReadGuid();
            Member234 = u.ReadInt32();
            Member238 = u.ReadInt64();
            Member240 = u.Read_4();
            Member448 = u.ReadInt32();
            Member44C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public string Member4;
        public int Member20C;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member210;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214;
        public int Member218;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member21C;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member220;
        public System.Guid Member224;
        public int Member234;
        public long Member238;
        public string Member240;
        public int Member448;
        public int Member44C;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member4 = new string('\0', 260);
            ret.Member240 = new string('\0', 260);
            return ret;
        }
        public Struct_1(int Member0, string Member4, int Member20C, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member210, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214, int Member218, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member21C, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member220, System.Guid Member224, int Member234, long Member238, string Member240, int Member448, int Member44C)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member20C = Member20C;
            this.Member210 = Member210;
            this.Member214 = Member214;
            this.Member218 = Member218;
            this.Member21C = Member21C;
            this.Member220 = Member220;
            this.Member224 = Member224;
            this.Member234 = Member234;
            this.Member238 = Member238;
            this.Member240 = Member240;
            this.Member448 = Member448;
            this.Member44C = Member44C;
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
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt64(Member10);
            m.WriteInt64(Member18);
            m.WriteInt32(Member20);
            m.Write_0(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadEnum16();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt64();
            Member18 = u.ReadInt64();
            Member20 = u.ReadInt32();
            Member28 = u.Read_0();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public int Member8;
        public int MemberC;
        public long Member10;
        public long Member18;
        public int Member20;
        public Struct_0 Member28;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, int Member8, int MemberC, long Member10, long Member18, int Member20, Struct_0 Member28)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
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
            m.WriteEnum16(Member0);
            m.WriteInt64(Member8);
            m.WriteInt64(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public long Member8;
        public long Member10;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, long Member8, long Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("91fd044b-902f-42c7-a945-6861bcf9309c", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int MapsStorageSvcOpen(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int MapsStorageSvcClose(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int MapsStorageSvcGetCurrentLocation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.Read_0();
            return u.ReadInt32();
        }
        public int MapsStorageSvcGetLocations(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_0[]>(new System.Func<Struct_0[]>(u.Read_5), false);
            return u.ReadInt32();
        }
        public int MapsStorageSvcGetMigrationState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_3 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.Read_2();
            return u.ReadInt32();
        }
        // async
        public int MapsStorageSvcValidateLocationAsync(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out Struct_4 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.Read_3();
            return u.ReadInt32();
        }
        public int MapsStorageSvcGetDataDirectory(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, ref string p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadConformantVaryingString();
            return u.ReadInt32();
        }
        public int MapsStorageSvcUseDefaultExternalStorage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int MapsStorageSvcQueueSwitchToDefaultExternalStorage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

