//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\termsrv.dll
// Interface ID: 2f59a331-bf7d-48cb-9e5c-7c090d76e8b8
// Interface Version: 1.0



namespace rpc_2f59a331_bf7d_48cb_9e5c_7c090d76e8b8_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_1(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public int[] Read_0()
        {
            return ReadConformantArray<int>();
        }
        public sbyte[] Read_1()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("2f59a331-bf7d-48cb-9e5c-7c090d76e8b8", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public sbyte RpcLicensingOpenServer(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            p1 = u.ReadInt32();
            return u.ReadSByte();
        }
        public void RpcLicensingCloseServer(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
        }
        public int RpcLicensingSetPolicy(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public sbyte RpcLicensingGetAvailablePolicyIds(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int[] p1, out int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadReferent<int[]>(new System.Func<int[]>(u.Read_0), false);
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            return u.ReadSByte();
        }
        public sbyte RpcLicensingGetPolicy(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            return u.ReadSByte();
        }
        public sbyte RpcLicensingGetPolicyInformation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref int p2, out sbyte[] p3, ref int p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(5, m);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_1), false);
            p4 = u.ReadInt32();
            p5 = u.ReadInt32();
            return u.ReadSByte();
        }
        public sbyte RpcLicensingDeactivateCurrentPolicy(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadInt32();
            return u.ReadSByte();
        }
        public sbyte RpcLicensingServerPing(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            return u.ReadSByte();
        }
        public int RpcGetSessionUnderArbitration(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcLicensingSetAadInfo(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, string p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int RpcLicensingGetAadInfo(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1, out string p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

