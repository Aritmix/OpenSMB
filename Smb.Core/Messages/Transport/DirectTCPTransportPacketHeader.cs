using Smb.Core.Messages;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Transport
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class DirectTCPTransportPacketHeader
    {
        public DirectTCPTransportPacketHeader()
        {
            StreamProtocolLength = new byte[3];
        }

        public Byte Zero => 0x00;


        /// <summary>
        /// The length, in bytes, of the SMB2Message in network byte order. This field does not include the 4-byte Direct TCP transport packet header; 
        /// rather, it is only the length of the enclosed SMB2Message.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public Byte[] StreamProtocolLength;

        public SMB2Message SMB2Message;
    }
}
