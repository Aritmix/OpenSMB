using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_READ_HASH_REQUEST
    {
        public SRV_READ_HASH_TYPES HashType;
        public SRV_READ_HASH_VERSIONS HashVersion;
        public SRV_READ_HASH_RETRIVAL_TYPES HashRetrievalType;
        public UInt32 Length;
        public UInt64 Offset;
    }

    internal enum SRV_READ_HASH_TYPES : UInt32
    {
        SRV_HASH_TYPE_PEER_DIST = 0x00000001
    }
    internal enum SRV_READ_HASH_VERSIONS : UInt32
    {
        SRV_HASH_VER_1 = 0x00000001,
        SRV_HASH_VER_2 = 0x00000002
    }
    internal enum SRV_READ_HASH_RETRIVAL_TYPES : UInt32
    {
        SRV_HASH_VER_1 = 0x00000001,
        SRV_HASH_VER_2 = 0x00000002
    }
}
