using Smb.Core.SID_IDENTIFIERS;
using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// This is a packet representation of the SID type (as specified in section 2.4.2) for use by block protocols. Multiple-byte fields are transmitted on the wire with an endianness specified by the protocol in question.
    /// </summary>
    internal struct SID
    {
        /// <summary>
        /// Revision (1 byte): An 8-bit unsigned integer that specifies the revision level of the SID. This value MUST be set to 0x01.
        /// </summary>
        public Byte Revision => 0x01;
        /// <summary>
        /// SubAuthorityCount (1 byte): An 8-bit unsigned integer that specifies the number of elements in the SubAuthority array. The maximum number of elements allowed is 15.
        /// </summary>
        
        public Byte SubAuthorityCount => (Byte)SubAuthority?.Length;
        /// <summary>
        /// IdentifierAuthority (6 bytes): A SID_IDENTIFIER_AUTHORITY structure that indicates the authority under which the SID was created. It describes the entity that created the SID. The Identifier Authority value {0,0,0,0,0,5} denotes SIDs created by the NT SID authority.
        /// </summary>
        public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
        /// <summary>
        /// SubAuthority (variable): A variable length array of unsigned 32-bit integers that uniquely identifies a principal relative to the IdentifierAuthority. 
        /// Its length is determined by SubAuthorityCount.
        /// </summary>
        public UInt32[] SubAuthority;
    }
}
