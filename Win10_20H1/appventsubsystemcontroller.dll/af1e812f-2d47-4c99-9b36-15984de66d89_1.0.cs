//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\appventsubsystemcontroller.dll
// Interface ID: af1e812f-2d47-4c99-9b36-15984de66d89
// Interface Version: 1.0



namespace rpc_af1e812f_2d47_4c99_9b36_15984de66d89_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
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
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
        public char[] Read_1()
        {
            return ReadConformantArray<char>();
        }
        public string[] Read_2()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<char[], long>(Member8, new System.Action<char[], long>(m.Write_1), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_1), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member8;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member8 = new char[0];
            return ret;
        }
        public Struct_1(int Member0, char[] Member8)
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
                base("af1e812f-2d47-4c99-9b36-15984de66d89", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int vfonts_server_GetListOfVirtualFonts(int p0, System.Guid p1, System.Guid p2, out int p3, out int p4, out string[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            m.WriteGuid(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadInt32();
            p4 = u.ReadInt32();
            p5 = u.ReadReferent<string[]>(new System.Func<string[]>(u.Read_2), false);
            return u.ReadInt32();
        }
        public int vfonts_server_StageFontFile(int p0, System.Guid p1, System.Guid p2, Struct_1 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            m.WriteGuid(p2);
            m.Write_0(p3);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

