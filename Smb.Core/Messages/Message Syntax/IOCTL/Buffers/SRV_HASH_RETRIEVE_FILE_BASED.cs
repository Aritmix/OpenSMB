using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_HASH_RETRIEVE_FILE_BASED
    {
        public UInt64 FileDataOffset;
        public UInt64 FileDataLength;
        public UInt32 BufferLength;
        public UInt32 Reserved => 0;
        public Byte[] Buffer;
    }
}
