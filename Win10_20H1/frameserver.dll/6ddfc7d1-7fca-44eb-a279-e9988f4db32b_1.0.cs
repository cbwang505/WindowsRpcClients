//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\frameserver.dll
// Interface ID: 6ddfc7d1-7fca-44eb-a279-e9988f4db32b
// Interface Version: 1.0



namespace rpc_6ddfc7d1_7fca_44eb_a279_e9988f4db32b_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(NtApiDotNet.NtFile p0)
        {
            WriteSystemHandle<NtApiDotNet.NtFile>(p0);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_6(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_7(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_10(NtApiDotNet.NtEvent p0)
        {
            WriteSystemHandle<NtApiDotNet.NtEvent>(p0);
        }
        public void Write_11(NtApiDotNet.NtSemaphore p0)
        {
            WriteSystemHandle<NtApiDotNet.NtSemaphore>(p0);
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
        public void Write_16(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_17(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_18(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_19(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_20(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_21(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_22(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_23(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_24(byte[] p0, long p1)
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
        public byte[] Read_0()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public NtApiDotNet.NtFile Read_3()
        {
            return ReadSystemHandle<NtApiDotNet.NtFile>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_5()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_6()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_7()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_9()
        {
            return ReadConformantArray<byte>();
        }
        public NtApiDotNet.NtEvent Read_10()
        {
            return ReadSystemHandle<NtApiDotNet.NtEvent>();
        }
        public NtApiDotNet.NtSemaphore Read_11()
        {
            return ReadSystemHandle<NtApiDotNet.NtSemaphore>();
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
        public byte[] Read_16()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_17()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_18()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_19()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_20()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_21()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_22()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_23()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_24()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("6ddfc7d1-7fca-44eb-a279-e9988f4db32b", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int Server_CreateClientContext(int p0, byte[] p1, int p2, out long p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<byte[], long>(m.Write_0), p2);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadInt64();
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int Server_EnableNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int Server_AddDeviceToClientContext(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, int p3, byte[] p4, int p5, byte[] p6, out int p7, out long p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_1), p3);
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<byte[], long>(m.Write_2), p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            p7 = u.ReadInt32();
            p8 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int Server_CreateMSKSHandle(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtFile p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.Read_3();
            return u.ReadInt32();
        }
        public int Server_GetFSStreamInformationSizes(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_GetFSStreamInformation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref int p2, ref byte[] p3, ref int p4, ref byte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p2));
            m.WriteInt32(p4);
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p4));
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.ReadInt32();
            p3 = u.Read_4();
            p4 = u.ReadInt32();
            p5 = u.Read_5();
            return u.ReadInt32();
        }
        public int Server_GetCurrentMediaType(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_SetCurrentMediaType(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int Server_SetStreamState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int Server_GetStreamState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_GetNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref byte[] p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            p2 = u.Read_6();
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_SendContextCommand(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, int p3, int p4, ref byte[] p5, int p6, ref byte[] p7, out int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<byte[], long>(m.Write_7), p4);
            m.WriteInt32(p6);
            m.WriteReferent(p7, new System.Action<byte[], long>(m.Write_8), p6);
            _Unmarshal_Helper u = SendReceive(11, m);
            p5 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_7), false);
            p7 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_8), false);
            p8 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_RegisterKSEvent(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, int p3, byte[] p4, long p5, NtApiDotNet.NtEvent p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteInt64(p5);
            m.Write_10(p6);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int Server_RegisterKSSemaphore(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, int p3, byte[] p4, int p5, long p6, NtApiDotNet.NtSemaphore p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteInt32(p5);
            m.WriteInt64(p6);
            m.Write_11(p7);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int Server_CloseClientContext(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int Server_GetCurrentMuxMediaType(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, ref byte[] p3, out int p4, int p5, ref byte[] p6, out int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_12), p2);
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<byte[], long>(m.Write_13), p5);
            _Unmarshal_Helper u = SendReceive(15, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_12), false);
            p4 = u.ReadInt32();
            p6 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_13), false);
            p7 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_SetCurrentMuxMediaType(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, byte[] p3, int p4, byte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<byte[], long>(m.Write_15), p4);
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int Server_GetMuxedMediaTypes(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, ref byte[] p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_16), p2);
            _Unmarshal_Helper u = SendReceive(17, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_16), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_GetMuxedStreamAttributes(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, ref byte[] p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_17), p2);
            _Unmarshal_Helper u = SendReceive(18, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_17), false);
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_SetBufferAccessMode(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int Server_AddMultipleSensorDevicesToClientContext(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, byte[] p3, int p4, ref byte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<byte[], long>(m.Write_18), p4);
            _Unmarshal_Helper u = SendReceive(20, m);
            p5 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_18), false);
            return u.ReadInt32();
        }
        public int Server_ShutdownContextSource(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, long p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int Server_SetDXGIAdapter(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(22, m);
            return u.ReadInt32();
        }
        public int Server_ContextKeepAlive(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref byte[] p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<byte[], long>(m.Write_19), p1);
            _Unmarshal_Helper u = SendReceive(23, m);
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_19), false);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_SetContextMetadataConfiguration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, byte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_20), p2);
            _Unmarshal_Helper u = SendReceive(24, m);
            return u.ReadInt32();
        }
        public int Server_GetContextMetadataSize(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(25, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int Server_GetContextMetadata(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, ref byte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_21), p2);
            _Unmarshal_Helper u = SendReceive(26, m);
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_21), false);
            return u.ReadInt32();
        }
        public int Server_CreateVMKSEvent(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, long p2, int p3, byte[] p4, int p5, out System.Guid p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt64(p2);
            m.WriteInt32(p3);
            m.Write_22(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(27, m);
            p6 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int Server_RegisterVMKSEvent(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(28, m);
            return u.ReadInt32();
        }
        public int Server_UnregisterVMKSEvent(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(29, m);
            return u.ReadInt32();
        }
        public int Server_SaveDeviceConfiguration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, byte[] p1, int p2, string p3, string p4, byte[] p5, int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_23(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            m.Write_24(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p6);
            m.WriteInt32(p6);
            _Unmarshal_Helper u = SendReceive(30, m);
            return u.ReadInt32();
        }
        public int Server_DeleteDeviceConfiguration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, byte[] p1, int p2, string p3, string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_23(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"));
            _Unmarshal_Helper u = SendReceive(31, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

