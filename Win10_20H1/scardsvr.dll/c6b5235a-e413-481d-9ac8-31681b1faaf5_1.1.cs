//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\scardsvr.dll
// Interface ID: c6b5235a-e413-481d-9ac8-31681b1faaf5
// Interface Version: 1.1



namespace rpc_c6b5235a_e413_481d_9ac8_31681b1faaf5_1_1
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_6(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_7(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_12(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_13(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_14(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_15(byte[] p0, long p1)
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
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_5()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_6()
        {
            return ReadConformantArray<int>();
        }
        public byte[] Read_7()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_9()
        {
            return ReadConformantArray<int>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_11()
        {
            return ReadConformantArray<int>();
        }
        public byte[] Read_12()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_13()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_14()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_15()
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_1), Member10);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_1), false);
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public int Member10;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, byte[] Member8, int Member10)
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
                base("c6b5235a-e413-481d-9ac8-31681b1faaf5", 1, 1)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_RPC_SCardBeginTransaction(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardCancel(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardConnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, string p3, out int p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadInt32();
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardControl(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, byte[] p3, int p4, out byte[] p5, ref int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_2), p4);
            m.WriteInt32(p4);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(3, m);
            p5 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_3), false);
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardDisconnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardEndTransaction(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardEstablishContext(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_RPC_SCardGetAttrib(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out byte[] p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_4), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardGetStatusChange(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, byte[] p2, int p3, ref int[] p4, int p5, out byte[] p6, out int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<byte[], long>(m.Write_5), p3);
            m.WriteInt32(p3);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(8, m);
            p4 = u.Read_6();
            p6 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_7), false);
            p7 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardGetTransmitCount(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(9, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardIsValidContext(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardListReaders(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, byte[] p1, int p2, out int[] p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<byte[], long>(m.Write_8), p2);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(11, m);
            p3 = u.ReadReferent<int[]>(new System.Func<int[]>(u.Read_9), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardLocateCards(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, byte[] p1, int p2, byte[] p3, int p4, byte[] p5, int p6, ref int[] p7, int p8, out byte[] p9, out int p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<byte[], long>(m.Write_8), p2);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_2), p4);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<byte[], long>(m.Write_10), p6);
            m.WriteInt32(p6);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p8);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(12, m);
            p7 = u.Read_11();
            p9 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_12), false);
            p10 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardReconnect(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, int p4, ref int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(13, m);
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardReleaseContext(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_RPC_SCardSetAttrib(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, byte[] p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_13), p4);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int s_RPC_SCardStatus(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2, out int p3, out byte[] p4, out int p5, out string p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(16, m);
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_14), false);
            p5 = u.ReadInt32();
            p6 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int s_RPC_SCardTransmit(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_0 p2, byte[] p3, int p4, int p5, out System.Nullable<Struct_0> p6, out byte[] p7, ref int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_0(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_2), p4);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(17, m);
            p6 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            p7 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_15), false);
            p8 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardGetReaderDeviceInstanceId(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(18, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RPC_SCardGetDeviceTypeId(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, ref int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(19, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

