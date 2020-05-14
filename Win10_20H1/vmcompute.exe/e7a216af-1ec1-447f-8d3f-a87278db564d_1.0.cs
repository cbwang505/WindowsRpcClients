//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\vmcompute.exe
// Interface ID: e7a216af-1ec1-447f-8d3f-a87278db564d
// Interface Version: 1.0

namespace rpc_e7a216af_1ec1_447f_8d3f_a87278db564d_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(NtApiDotNet.NtFile p0)
        {
            WriteSystemHandle<NtApiDotNet.NtFile>(p0);
        }
        public void Write_2(NtApiDotNet.NtToken p0)
        {
            WriteSystemHandle<NtApiDotNet.NtToken>(p0);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(NtApiDotNet.NtEvent p0)
        {
            WriteSystemHandle<NtApiDotNet.NtEvent>(p0);
        }
        public void Write_5(NtApiDotNet.NtProcess p0)
        {
            WriteSystemHandle<NtApiDotNet.NtProcess>(p0);
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
        public NtApiDotNet.NtFile Read_1()
        {
            return ReadSystemHandle<NtApiDotNet.NtFile>();
        }
        public NtApiDotNet.NtToken Read_2()
        {
            return ReadSystemHandle<NtApiDotNet.NtToken>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public NtApiDotNet.NtEvent Read_4()
        {
            return ReadSystemHandle<NtApiDotNet.NtEvent>();
        }
        public NtApiDotNet.NtProcess Read_5()
        {
            return ReadSystemHandle<NtApiDotNet.NtProcess>();
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
            m.WriteInt32(Member0);
            m.Write_1(Member8);
            m.Write_1(Member10);
            m.Write_1(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_1();
            Member10 = u.Read_1();
            Member18 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.NtFile Member8;
        public NtApiDotNet.NtFile Member10;
        public NtApiDotNet.NtFile Member18;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, NtApiDotNet.NtFile Member8, NtApiDotNet.NtFile Member10, NtApiDotNet.NtFile Member18)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e7a216af-1ec1-447f-8d3f-a87278db564d", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int HcsRpc_EnumerateSystems(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_CreateSystem(string p0, string p1, NtApiDotNet.Ndr.Marshal.NdrInterfacePointer p2, NtApiDotNet.NtToken p3, int p4, byte[] p5, long p6, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p7, out string p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInterfacePointer(p2);
            m.Write_2(p3);
            m.WriteInt32(p4);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p4);
            m.WriteInt64(p6);
            _Unmarshal_Helper u = SendReceive(1, m);
            p7 = u.ReadContextHandle();
            p8 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_OpenSystem(string p0, int p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HcsRpc_StartSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_ShutdownSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_TerminateSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(5, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_PauseSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(6, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_ResumeSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_SaveSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_CrashSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(9, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_GetSystemProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out string p3, out string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt64(p2);
            _Unmarshal_Helper u = SendReceive(10, m);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_ModifySystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, NtApiDotNet.NtToken p2, long p3, out string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.Write_2(p2);
            m.WriteInt64(p3);
            _Unmarshal_Helper u = SendReceive(11, m);
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_RegisterSystemNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtEvent p1, out NtApiDotNet.NtProcess p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            p1 = u.Read_4();
            p2 = u.Read_5();
            return u.ReadInt32();
        }
        public int HcsRpc_UnregisterSystemNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int HcsRpc_QuerySystemNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out long p2, out int p3, out string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt64();
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_CloseSystem(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(15, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HcsRpc_CreateProcess(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, byte[] p3, out Struct_0 p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5, out string p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(16, m);
            p4 = u.Read_0();
            p5 = u.ReadContextHandle();
            p6 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_OpenProcess(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(17, m);
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HcsRpc_SignalProcess(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(18, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_GetProcessInfo(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(19, m);
            p1 = u.Read_0();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_GetProcessProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(20, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_ModifyProcess(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(21, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_RegisterProcessNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.NtEvent p1, out NtApiDotNet.NtProcess p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(22, m);
            p1 = u.Read_4();
            p2 = u.Read_5();
            return u.ReadInt32();
        }
        public int HcsRpc_UnregisterProcessNotifications(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(23, m);
            return u.ReadInt32();
        }
        public int HcsRpc_QueryProcessNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out long p2, out int p3, out string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(24, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt64();
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_CloseProcess(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(25, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int HcsRpc_GetServiceProperties(string p0, out string p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(26, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int HcsRpc_ModifyServiceSettings(string p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(27, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
    }
    #endregion
}

