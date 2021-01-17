using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class HASH_HEADER
    {
        public HASH_HEADER_HASH_TYPES HashType;
        public HASH_HEADER_HASH_VERSIONS HashVersion;
        public FILETIME SourceFileChangeTime;
        public UInt64 SourceFileSize;
        public UInt32 HashBlobLength;
        public UInt32 HashBlobOffset;
        public UInt16 Dirty;
        public UInt16 SourceFileNameLength => (UInt16)SourceFileName?.Length;
        public String SourceFileName;

    }

    internal enum HASH_HEADER_HASH_TYPES : UInt32
    {
        SRV_HASH_TYPE_PEER_DIST = 0x00000001
    }
    internal enum HASH_HEADER_HASH_VERSIONS : UInt32
    {
        SRV_HASH_VER_1 = 0x00000001,
        SRV_HASH_VER_2 = 0x00000002
    }
}
