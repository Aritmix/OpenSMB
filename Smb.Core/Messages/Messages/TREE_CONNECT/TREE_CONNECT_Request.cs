using System;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 TREE_CONNECT Request packet is sent by a client to request access to a particular share on the server. This request is composed of an SMB2 Packet Header (section 2.2.1) that is followed by this request structure.
    /// </summary>
    internal struct TREE_CONNECT_Request
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 9, indicating the size of the request structure, not including the header. The client MUST set it to this value regardless of how long Buffer[] actually is in the request being sent.
        /// </summary>
        public UInt16 StructureSize => 9;
        /// <summary>
        /// DialectCount (2 bytes): The number of dialects that are contained in the Dialects[] array. This value MUST be greater than 0.<7>
        /// </summary>
        public TreeConnectFlags Flags;
        /// <summary>
        /// PathOffset (2 bytes): The offset, in bytes, of the full share path name from the beginning of the packet header. The full share pathname is Unicode in the form "\\server\share" for the request. The server component of the path MUST be less than 256 characters in length, and it MUST be a NetBIOS name, a fully qualified domain name (FQDN), or a textual IPv4 or IPv6 address. The share component of the path MUST be less than or equal to 80 characters in length. The share name MUST NOT contain any invalid characters, as specified in [MS-FSCC] section 2.1.6. <26>
        /// </summary>
        public UInt16 PathOffset;
        /// <summary>
        /// PathLength (2 bytes): The length, in bytes, of the full share path name.
        /// </summary>
        public UInt16 PathLength;
        /// <summary>
        /// Buffer (variable): If SMB2_TREE_CONNECT_FLAG_EXTENSION_PRESENT is not set in the Flags field of this structure, this field is a variable-length buffer that contains the full share path name.
        /// If SMB2_TREE_CONNECT_FLAG_EXTENSION_PRESENT is set in the Flags field in this structure, this field is a variable-length buffer that contains the tree connect request extension, as specified in section 2.2.9.1.
        /// </summary>
        public Byte[] Buffer;
    }
}
