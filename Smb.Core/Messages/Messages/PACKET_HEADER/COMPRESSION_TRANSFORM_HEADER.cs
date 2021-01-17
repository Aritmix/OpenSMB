using System;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message.Packet
{
    [StructLayout(layoutKind:LayoutKind.Sequential, Pack = 1)]
    public class COMPRESSION_TRANSFORM_HEADER : PacketHeaderBase
    {
        public UInt32 OriginalCompressedSegmentSize;

        public UInt16 CompressionAlgorithm;
        public UInt16 Reserved => 0;

        public UInt32 Offset;
    }
}
