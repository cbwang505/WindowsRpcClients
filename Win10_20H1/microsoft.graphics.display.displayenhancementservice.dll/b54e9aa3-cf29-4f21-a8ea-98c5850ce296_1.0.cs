//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\microsoft.graphics.display.displayenhancementservice.dll
// Interface ID: b54e9aa3-cf29-4f21-a8ea-98c5850ce296
// Interface Version: 1.0



namespace rpc_b54e9aa3_cf29_4f21_a8ea_98c5850ce296_1_0
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
        public void Write_2(Struct_1[] p0, long p1)
        {
            WriteVaryingArray<Struct_1>(p0, p1);
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
        public Struct_1[] Read_2()
        {
            return ReadVaryingArray<Struct_1>();
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
            m.WriteUInt3264(Member0);
            m.WriteUInt3264(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadUInt3264();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member8)
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
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4, int Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("b54e9aa3-cf29-4f21-a8ea-98c5850ce296", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int DeoRpcServerOpenContextHandle(Struct_0 p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int DeoRpcServerCloseContextHandle(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStartViewPropertyChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStartCanOverrideChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStartIsOverrideActiveChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerTriggerViewPropertyChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerTriggerCanOverrideChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerTriggerIsOverrideActiveChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStopViewPropertyChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStopCanOverrideChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStopIsOverrideActiveChangedCallbacks(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStartOverride(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerStopOverride(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerGetCanOverride(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetIsOverrideActive(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetIsBrightnessOverrideSupported(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetIsBrightnessNitsOverrideSupported(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetSupportedMillinitRanges(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, ref short p1, ref Struct_1[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt16(p1);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p1));
            _Unmarshal_Helper u = SendReceive(17, m);
            p1 = u.ReadInt16();
            p2 = u.Read_2();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetBrightnessLevel(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(18, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetBrightnessMillinits(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(19, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetBrightnessLevelForBrightnessScenario(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, out sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(20, m);
            p2 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetBrightnessMillinitsForBrightnessScenario(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(21, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int DeoRpcServerSetBrightnessLevel(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, sbyte p1, sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteSByte(p1);
            m.WriteSByte(p2);
            _Unmarshal_Helper u = SendReceive(22, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerSetBrightnessMillinits(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteSByte(p2);
            _Unmarshal_Helper u = SendReceive(23, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerSetBrightnessScenario(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteSByte(p2);
            _Unmarshal_Helper u = SendReceive(24, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerGetIsColorOverrideSupported(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(25, m);
            p1 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int DeoRpcServerGetColorScenario(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(26, m);
            p1 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int DeoRpcServerSetColorScenario(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(27, m);
            return u.ReadInt32();
        }
        public int DeoRpcServerSaveForSystem(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteSByte(p1);
            _Unmarshal_Helper u = SendReceive(28, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

