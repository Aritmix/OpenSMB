using Smb.Core.SID_IDENTIFIERS;
using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// This is a packet representation of the SID type (as specified in section 2.4.2) for use by block protocols. Multiple-byte fields are transmitted on the wire with an endianness specified by the protocol in question.
    /// </summary>
    internal struct GUID
    {
        /// <summary>
        ///Data1 (4 bytes): The value of the Data1 member (section 2.3.4), in little-endian byte order.
        /// </summary>
        public UInt32 Data1;
        /// <summary>
        /// SubAuthorityCount (1 byte): An 8-bit unsigned integer that specifies the number of elements in the SubAuthority array. The maximum number of elements allowed is 15.
        /// </summary>
        public UInt16 Data2;
        /// <summary>
        /// Data3 (2 bytes): The value of the Data3 member (section 2.3.4), in little-endian byte order.
        /// </summary>
        public UInt16 Data3;
        /// <summary>
        /// Data4 (8 bytes): The value of the Data4 member (section 2.3.4), in little-endian byte order.
        /// </summary>
        public UInt64 Data4;
    }
}
