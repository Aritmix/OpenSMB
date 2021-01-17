using System;
using System.Dynamic;

namespace Smb.Core.Messages.Message.Packet
{
    public abstract class PacketHeaderBase
    {
        /// <summary>
        /// ProtocolId (4 bytes): The protocol identifier. 
        /// The value MUST be set to 0x424D53FE, also represented as (in network order) 0xFE, 'S', 'M', and 'B'.
        /// </summary>
        public Byte[] ProtocolId => new Byte[] { 0xFE, 0x53, 0x4D, 0x42 };
      
    }
}
