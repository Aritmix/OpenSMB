using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 LOGOFF Request packet is sent by the client to request termination of a particular session. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class WRITE_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 49;
        /// <summary>
        /// </summary>
        public UInt16 DataOffset => 0;

        public UInt32 Length;
        public UInt64 Offset;
        public FILEID FileId;
        public WRITE_REQUEST_CHANNEL Channel;
        public UInt32 RemainingBytes;
        public UInt16 WriteChannelInfoOffset;
        public UInt16 WriteChannelInfoLength;
        public WRITE_REQUEST_FLAGS Flags;

        public Byte[] Buffer;
    }

    internal enum WRITE_REQUEST_FLAGS : UInt32
    {
        NONE = 0x00000000,
        SMB2_WRITEFLAG_WRITE_THROUGH = 0x00000001,
        SMB2_WRITEFLAG_WRITE_UNBUFFERED = 0x00000002
    }
    internal enum WRITE_REQUEST_CHANNEL : UInt32
    {
        SMB2_CHANNEL_NONE = 0x00000000,
        SMB2_CHANNEL_RDMA_V1 = 0x00000001,
        SMB2_CHANNEL_RDMA_V1_INVALIDATE = 0x00000002
    }
}
