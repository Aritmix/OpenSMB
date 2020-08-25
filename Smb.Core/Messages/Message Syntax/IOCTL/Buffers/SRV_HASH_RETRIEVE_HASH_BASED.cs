using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_HASH_RETRIEVE_HASH_BASED
    {
        public UInt64 Offset;
        public UInt32 BufferLength;
        public UInt32 Reserved => 0;
        public Byte[] Buffer;

    }
}
