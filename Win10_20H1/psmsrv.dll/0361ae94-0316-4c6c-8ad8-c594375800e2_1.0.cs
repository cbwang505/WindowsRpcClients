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
// Interface ID: 0361ae94-0316-4c6c-8ad8-c594375800e2
// Interface Version: 1.0



namespace rpc_0361ae94_0316_4c6c_8ad8_c594375800e2_1_0
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
        public void Write_4(string p0)
        {
            WriteFixedString(p0, 232);
        }
        public void Write_5(byte[] p0)
        {
            WriteFixedByteArray(p0, 68);
        }
        public void Write_6(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_7(Struct_0[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_0>(p0, p1, p2);
        }
        public void Write_8(Struct_2[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_2>(p0, p1, p2);
        }
        public void Write_9(NtApiDotNet.NtJob p0)
        {
            WriteSystemHandle<NtApiDotNet.NtJob>(p0);
        }
        public void Write_10(NtApiDotNet.NtJob[] p0, long p1, long p2)
        {
            WriteConformantVaryingArrayCallback<NtApiDotNet.NtJob>(p0, new System.Action<NtApiDotNet.NtJob>(this.Write_9), p1, p2);
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
        public string Read_4()
        {
            return ReadFixedString(232);
        }
        public byte[] Read_5()
        {
            return ReadFixedByteArray(68);
        }
        public int[] Read_6()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public Struct_0[] Read_7()
        {
            return ReadConformantVaryingStructArray<Struct_0>();
        }
        public Struct_2[] Read_8()
        {
            return ReadConformantVaryingStructArray<Struct_2>();
        }
        public NtApiDotNet.NtJob Read_9()
        {
            return ReadSystemHandle<NtApiDotNet.NtJob>();
        }
        public NtApiDotNet.NtJob[] Read_10()
        {
            return ReadConformantVaryingArrayCallback<NtApiDotNet.NtJob>(new System.Func<NtApiDotNet.NtJob>(this.Read_9));
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
            m.Write_1(Member0);
            m.WriteInt32(Member44);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member48, "Member48"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member44 = u.ReadInt32();
            Member48 = u.Read_4();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_1 Member0;
        public int Member44;
        public string Member48;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member48 = new string('\0', 232);
            return ret;
        }
        public Struct_0(Struct_1 Member0, int Member44, string Member48)
        {
            this.Member0 = Member0;
            this.Member44 = Member44;
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
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public byte[] Member0;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member0 = new byte[68];
            return ret;
        }
        public Struct_1(byte[] Member0)
        {
            this.Member0 = Member0;
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
            m.WriteInt32(Member0);
            m.WriteInt64(Member8);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public long Member8;
        public int Member10;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, long Member8, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
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
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_3(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("0361ae94-0316-4c6c-8ad8-c594375800e2", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PsmSrvQueryCurrentApplications(string p0, string p1, int p2, out int p3, out Struct_0[] p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadInt32();
            p4 = u.Read_7();
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationHosts(Struct_0 p0, int p1, out int p2, out Struct_2[] p3, out NtApiDotNet.NtJob[] p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadInt32();
            p3 = u.Read_8();
            p4 = u.Read_10();
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationHostExecutionState(long p0, int p1, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int PsmSrvQueryApplicationHostJob(long p0, out Struct_2 p1, out NtApiDotNet.NtJob p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.Read_2();
            p2 = u.Read_9();
            return u.ReadInt32();
        }
        public uint PsmSrvConnect(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_3 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            p1 = u.Read_3();
            return u.ReadUInt32();
        }
        public uint PsmSrvDisconnect(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint PsmSrvSubscribeToNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, string p2, out long p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(6, m);
            p3 = u.ReadInt64();
            return u.ReadUInt32();
        }
        public uint PsmSrvUnsubscribeFromNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}

