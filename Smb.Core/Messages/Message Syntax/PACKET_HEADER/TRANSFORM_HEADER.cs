using System;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message.Packet
{
    [StructLayout(layoutKind:LayoutKind.Sequential)]
    public class TRANSFORM_HEADER : PacketHeaderBase
    {

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] Signature;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] Nonce;
        public UInt32 OriginalMessageSize;
        public UInt16 Reserved => 0;

        /// <summary>
        /// The message is encrypted using the AES128 CCM algorithm.
        /// </summary>
        public UInt16 EncryptionAlgorithm => 0x0001;
    }
}
