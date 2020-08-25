using System;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    [Flags]
    public enum MOVE_DST_IPADDR_TYPE : UInt32
    {
        /// <summary>
        /// The type of destination IP address in this structure is IPv4 address. The fields after Reserved field in this structure are interpreted as IPv4Address followed by Reserved2 as described below.
        /// </summary>
        MOVE_DST_IPADDR_V4 = 0x00000001,
        /// <summary>
        /// The type of destination IP address in this structure is IPv6 address. The field after Reserved field in this structure is interpreted as IPv6Address as described below.
        /// </summary>
        MOVE_DST_IPADDR_V6 = 0x00000002

    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct MOVE_DST_IPADDR
    {
        /// <summary>
        /// Type (4 bytes): This field indicates the type of destination IP address. 
        /// </summary>
        public MOVE_DST_IPADDR_TYPE Type;
        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. The server SHOULD set this field to zero, and the client MUST ignore it on receipt.
        /// </summary>
        public UInt32 Reserved => 0;
        /// <summary>
        /// (IPv4Address/Reserved2)/ IPv6Address (16 bytes): This field is interpreted in different ways depending on the value of the Type field.
        /// </summary>
        public IPvxAddress IPvxAddress;

    }
}
