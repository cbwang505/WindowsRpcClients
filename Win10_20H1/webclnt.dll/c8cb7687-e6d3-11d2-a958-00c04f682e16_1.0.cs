//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\webclnt.dll
// Interface ID: c8cb7687-e6d3-11d2-a958-00c04f682e16
// Interface Version: 1.0



namespace rpc_c8cb7687_e6d3_11d2_a958_00c04f682e16_1_0
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
        public void Write_2(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_3(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_4(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_5(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_6(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_7(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_8(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_9(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_10(char[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<char>(p0, p1, p2);
        }
        public void Write_11(Struct_1[] p0, long p1)
        {
            WriteConformantStructArray<Struct_1>(p0, p1);
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
        public sbyte[] Read_2()
        {
            return ReadConformantArray<sbyte>();
        }
        public char[] Read_3()
        {
            return ReadConformantArray<char>();
        }
        public sbyte[] Read_4()
        {
            return ReadConformantArray<sbyte>();
        }
        public char[] Read_5()
        {
            return ReadConformantArray<char>();
        }
        public char[] Read_6()
        {
            return ReadConformantVaryingArray<char>();
        }
        public Struct_1[] Read_7()
        {
            return ReadConformantStructArray<Struct_1>();
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
            m.WriteInt64(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(long Member0)
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
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_2), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_2), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, sbyte[] Member8)
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
                base("c8cb7687-e6d3-11d2-a958-00c04f682e16", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int DavrCreateConnection(string p0, string p1, int p2, char[] p3, int p4, string p5, int p6, int p7, sbyte[] p8, string p9, int p10, sbyte p11, sbyte p12, int p13, char[] p14)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<char[], long>(m.Write_3), (p4 / 2));
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<string, long>(m.Write_4), p6);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            m.WriteReferent(p8, new System.Action<sbyte[], long>(m.Write_5), p7);
            m.WriteReferent(p9, new System.Action<string, long>(m.Write_6), p10);
            m.WriteInt32(p10);
            m.WriteSByte(p11);
            m.WriteSByte(p12);
            m.WriteInt32(p13);
            m.WriteReferent(p14, new System.Action<char[], long>(m.Write_7), (p13 / 2));
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int DavrGetCookie(string p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int DavrSetCookie(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int DavrDoesServerDoDav(string p0, string p1, ref sbyte p2, string p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteSByte(p2);
            m.WriteReferent(p3, new System.Action<string, long>(m.Write_8), p4);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrIsValidShare(string p0, string p1, string p2, int p3, ref sbyte p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteReferent(p2, new System.Action<string, long>(m.Write_9), p3);
            m.WriteInt32(p3);
            m.WriteSByte(p4);
            _Unmarshal_Helper u = SendReceive(4, m);
            p4 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrEnumNetUses(ref int p0, out string p1, out string p2, ref sbyte p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteSByte(p3);
            _Unmarshal_Helper u = SendReceive(5, m);
            p0 = u.ReadInt32();
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrEnumShares(ref int p0, string p1, out string p2, ref sbyte p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteSByte(p3);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadInt32();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrEnumServers(ref int p0, out string p1, ref sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteSByte(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            p0 = u.ReadInt32();
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrGetConnection(string p0, out string p1, ref sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteSByte(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DavrDeleteConnection(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int DavrCancelConnectionsToServer(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int DavrGetUser(string p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(11, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int DavrConnectionExist(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int BeginChildren(out char[] p0, int p1, out int p2, ref Struct_0 p3, ref Struct_0 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p1);
            m.Write_0(p3);
            m.Write_0(p4);
            _Unmarshal_Helper u = SendReceive(13, m);
            p0 = u.Read_6();
            p2 = u.ReadInt32();
            p3 = u.Read_0();
            p4 = u.Read_0();
            return u.ReadInt32();
        }
        public int DavrFreeUsedDiskSpace(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        public int DavrGetTheLockOwnerOfTheFile(string p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int DavrInvalidateCache(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public sbyte DavrIsWebClientRunning()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadSByte();
        }
        public int DavrGetServerAuthType(string p0, string p1, out int p2, out Struct_1[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(18, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<Struct_1[]>(new System.Func<Struct_1[]>(u.Read_7), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

