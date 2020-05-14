//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\smsroutersvc.dll
// Interface ID: acd792e4-5239-48b6-8baf-7d0a79a64ac0
// Interface Version: 0.0



namespace rpc_acd792e4_5239_48b6_8baf_7d0a79a64ac0_0_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_2(string[] p0, long p1)
        {
            WriteConformantStringArray(p0, new System.Action<string>(this.WriteTerminatedString), p1);
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
        public int[] Read_1()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public string[] Read_2()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
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
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
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
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("acd792e4-5239-48b6-8baf-7d0a79a64ac0", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcSmsRouter_GetRegistrationList(string p0, out string[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadReferent<string[]>(new System.Func<string[]>(u.Read_2), false);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_RegisterForMessagesPersistent(string p0, string p1, string p2, System.Nullable<Struct_0> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteReferent(p3, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_UnregisterForMessagesPersistent(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_RegisterForMessagesTransient(string p0, string p1, string p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_UnregisterForMessagesTransient(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_GetMessageAvailableEvent(string p0, string p1, out Struct_0 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.Read_0();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_GetMessage(string p0, ref long p1, out string p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadInt64();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_AcknowledgeMessage(string p0, long p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_SendMessage(string p0, string p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out Struct_0 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadContextHandle();
            p3 = u.Read_0();
            return u.ReadInt32();
        }
        public int RpcSmsRouter_SendMessageClose(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int SetBroadcastConfiguration(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int SetBroadcastConfiguration_11(string p0, int p1, out string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int SetBroadcastConfiguration_12(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_SetSmscAddress(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_GetSmscAddress(string p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(14, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RpcSmsRouter_GetSmsDeviceStatusEvent(string p0, out Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.Read_0();
            return u.ReadInt32();
        }
    }
    #endregion
}
