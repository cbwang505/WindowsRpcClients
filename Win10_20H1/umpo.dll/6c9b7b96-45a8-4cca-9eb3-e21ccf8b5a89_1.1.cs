//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\umpo.dll
// Interface ID: 6c9b7b96-45a8-4cca-9eb3-e21ccf8b5a89
// Interface Version: 1.1



namespace rpc_6c9b7b96_45a8_4cca_9eb3_e21ccf8b5a89_1_1
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_3(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_4(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_5(System.Guid[] p0, long p1)
        {
            WriteVaryingArray<System.Guid>(p0, p1);
        }
        public void Write_6(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_7(Struct_2[] p0, long p1)
        {
            WriteConformantStructArray<Struct_2>(p0, p1);
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
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public sbyte[] Read_2()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_3()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_4()
        {
            return ReadConformantArray<sbyte>();
        }
        public System.Guid[] Read_5()
        {
            return ReadVaryingArray<System.Guid>();
        }
        public sbyte[] Read_6()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_2[] Read_7()
        {
            return ReadConformantStructArray<Struct_2>();
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
            m.WriteEnum16(Member4);
            m.WriteEnum16(Member8);
            m.WriteEnum16(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadEnum16();
            Member8 = u.ReadEnum16();
            MemberC = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member8, NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
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
            m.WriteSByte(Member0);
            m.WriteInt64(Member8);
            m.WriteInt64(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public sbyte Member0;
        public long Member8;
        public long Member10;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(sbyte Member0, long Member8, long Member10)
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
                base("6c9b7b96-45a8-4cca-9eb3-e21ccf8b5a89", 1, 1)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int UmpoRpcGetPowerConfiguration(out Struct_0 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.Read_0();
            return u.ReadInt32();
        }
        public int UmpoRpcReadFromSystemPowerKey(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, int p3, ref System.Nullable<int> p4, int p5, ref sbyte[] p6, int p7, out int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<sbyte[], long>(m.Write_2), p7);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(1, m);
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p6 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_2), false);
            p8 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcReadFromUserPowerKey(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, int p3, int p4, ref sbyte[] p5, int p6, out int p7, ref System.Nullable<NtApiDotNet.Ndr.Marshal.NdrEnum16> p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<sbyte[], long>(m.Write_3), p6);
            m.WriteInt32(p6);
            m.WriteReferent(p8, new System.Action<NtApiDotNet.Ndr.Marshal.NdrEnum16>(m.WriteEnum16));
            _Unmarshal_Helper u = SendReceive(2, m);
            p5 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_3), false);
            p7 = u.ReadInt32();
            p8 = u.ReadReferentValue<NtApiDotNet.Ndr.Marshal.NdrEnum16>(new System.Func<NtApiDotNet.Ndr.Marshal.NdrEnum16>(u.ReadEnum16), false);
            return u.ReadInt32();
        }
        public int UmpoRpcReadACValue(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, ref System.Nullable<int> p3, ref sbyte[] p4, int p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<sbyte[], long>(m.Write_4), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_4), false);
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcReadDCValue(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, ref System.Nullable<int> p3, ref sbyte[] p4, int p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p3, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p4, new System.Action<sbyte[], long>(m.Write_4), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_4), false);
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcWriteToSystemPowerKey(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, int p3, int p4, int p5, sbyte[] p6, int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"), p7);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int UmpoRpcWriteToUserPowerKey(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, System.Nullable<System.Guid> p2, int p3, int p4, sbyte[] p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p6);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int UmpoRpcApplyPowerRequestOverride()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int UmpoRpcApplyPowerSetting(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int UmpoRpcSetActiveScheme(System.Nullable<System.Guid> p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int UmpoRpcGetActiveScheme(out System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(10, m);
            p0 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int UmpoRpcSetActiveOverlayScheme(System.Nullable<System.Guid> p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int UmpoRpcGetActualOverlayScheme(out System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(12, m);
            p0 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int UmpoRpcGetEffectiveOverlayScheme(out System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(13, m);
            p0 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int UmpoRpcGetOverlaySchemes(out System.Guid[] p0, out int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(14, m);
            p0 = u.Read_5();
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcRestoreDefaultScheme(System.Nullable<System.Guid> p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int UmpoRpcRestoreDefaultSchemesAll()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int UmpoRpcDuplicateScheme(System.Guid p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadInt32();
        }
        public int UmpoRpcDeleteScheme(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int UmpoRpcImportScheme(string p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int UmpoRpcReplaceDefaultPowerSchemes()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int UmpoRpcLegacyEventRegisterNotification(NtApiDotNet.Ndr.Marshal.NdrUInt3264 p0, string p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteUInt3264(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int UmpoRpcEnumerate(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, int p2, int p3, ref sbyte[] p4, int p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<sbyte[], long>(m.Write_4), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(22, m);
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_4), false);
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcReadSecurityDescriptor(int p0, System.Nullable<System.Guid> p1, ref sbyte[] p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<sbyte[], long>(m.Write_6), p3);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(23, m);
            p2 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_6), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int UmpoRpcWriteSecurityDescriptor(int p0, System.Nullable<System.Guid> p1, sbyte[] p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(24, m);
            return u.ReadInt32();
        }
        public int UmpoRpcSettingAccessCheck(int p0, System.Nullable<System.Guid> p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(25, m);
            return u.ReadInt32();
        }
        public int UmpoRpcCreateSetting(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(26, m);
            return u.ReadInt32();
        }
        public int UmpoRpcCreatePossibleSetting(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(27, m);
            return u.ReadInt32();
        }
        public int UmpoRpcRemoveSetting(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(28, m);
            return u.ReadInt32();
        }
        public int UmpoSetExpectedUserAwayIntervals(int p0, Struct_2[] p1, int p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(29, m);
            return u.ReadInt32();
        }
        public int UmpoClearExpectedUserAwayIntervals(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(30, m);
            return u.ReadInt32();
        }
        public int UmpoGetMinUserAwayPredictionInterval(out sbyte p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(31, m);
            p0 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int UmpoRpcGetAdaptiveStandbyDiagnostics(int p0, int p1, ref sbyte[] p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<sbyte[], long>(m.Write_6), p3);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(32, m);
            p2 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_6), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

