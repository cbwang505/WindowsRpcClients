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
// Interface ID: cc4b408c-4c4e-422f-9849-47bb47bd4d2e
// Interface Version: 1.0



namespace rpc_cc4b408c_4c4e_422f_9849_47bb47bd4d2e_1_0
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
        public void Write_5(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_6(Struct_3[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<Struct_3>(p0, p1, p2);
        }
        public void Write_7(string p0)
        {
            WriteFixedString(p0, 32);
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
        public string Read_5()
        {
            return ReadFixedString(256);
        }
        public Struct_3[] Read_6()
        {
            return ReadConformantVaryingArray<Struct_3>();
        }
        public string Read_7()
        {
            return ReadFixedString(32);
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
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"));
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member208, "Member208"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.Read_5();
            Member208 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public string Member8;
        public string Member208;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member8 = new string('\0', 256);
            ret.Member208 = new string('\0', 256);
            return ret;
        }
        public Struct_1(int Member0, int Member4, string Member8, string Member208)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member208 = Member208;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0, Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public Struct_3[] Member8;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member8 = new Struct_3[0];
            return ret;
        }
        public Struct_2(int Member0, Struct_3[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
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
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.Read_7();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public string Member8;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member8 = new string('\0', 32);
            return ret;
        }
        public Struct_3(long Member0, string Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("cc4b408c-4c4e-422f-9849-47bb47bd4d2e", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int NARPCRuleRegister(string p0, Struct_0 p1, out Struct_1 p2, out long p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.Read_1();
            p3 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int NARPCRuleQuery(long p0, Struct_0 p1, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int NARPCRuleUnregister(long p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int NARPCRuleValidate(string p0, out Struct_1 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.Read_1();
            return u.ReadInt32();
        }
        public int NARPCDynamicLockStart()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int NARPCDynamicLockStop()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int NARPCDynamicLockForceEvaluate()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int NARPCDynamicLockShouldSkipGracePeriod(long p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int NARPCDynamicLockShouldIgnoreUserActivity(long p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int NARPCDynamicLockShouldIgnoreDisplayRequestActivity(long p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int NARPCDeviceUnlockStart(string p0, string p1, out System.Nullable<Struct_2> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(10, m);
            p2 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_2), false);
            return u.ReadInt32();
        }
        public int NARPCDeviceUnlockStop()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

