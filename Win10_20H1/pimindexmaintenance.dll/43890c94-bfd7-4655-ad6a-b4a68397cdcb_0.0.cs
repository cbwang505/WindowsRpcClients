//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\pimindexmaintenance.dll
// Interface ID: 43890c94-bfd7-4655-ad6a-b4a68397cdcb
// Interface Version: 0.0



namespace rpc_43890c94_bfd7_4655_ad6a_b4a68397cdcb_0_0
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
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 3);
        }
        public void Write_4(Struct_1[] p0, long p1)
        {
            WriteConformantStructArray<Struct_1>(p0, p1);
        }
        public void Write_5(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
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
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_3()
        {
            return ReadFixedPrimitiveArray<int>(3);
        }
        public Struct_1[] Read_4()
        {
            return ReadConformantStructArray<Struct_1>();
        }
        public int[] Read_5()
        {
            return ReadConformantArray<int>();
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
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_2), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_2), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, byte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
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
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_3();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member0 = new int[3];
            return ret;
        }
        public Struct_1(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("43890c94-bfd7-4655-ad6a-b4a68397cdcb", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PimIMService_UpdateStores(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_UpdateItems(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_RebuildAggregateCache()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int PimIMService_Suspend(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_Resume(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_CacheAggregateCacheFileMapping()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int PimIMService_LoadAggregateCache()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int PimIMService_CreateIndexedFilter(int p0, int p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(7, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PimIMService_SetStaticFilter(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1, int p2, int p3, Struct_1[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<Struct_1[], long>(m.Write_4), p3);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int PimIMService_GetIndexedProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int[] p2, out int[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<int[]>(new System.Func<int[]>(u.Read_5), false);
            p3 = u.ReadReferent<int[]>(new System.Func<int[]>(u.Read_5), false);
            return u.ReadInt32();
        }
        public int PimIMService_FindNextServerMatch(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out int p2, out int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_SetFilter(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(11, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int PimIMService_Reset(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public void PimIMService_CloseIndexedFilter(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            p0 = u.ReadContextHandle();
        }
    }
    #endregion
}

