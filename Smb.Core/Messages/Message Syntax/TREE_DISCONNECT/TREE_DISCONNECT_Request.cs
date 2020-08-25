using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 TREE_DISCONNECT Request packet is sent by the client to request that the tree connect that is specified in the TreeId within the SMB2 header be disconnected. This request is composed of an SMB2 header, as specified in section 2.2.1, that is followed by this variable-length request structure.
    /// </summary>
    internal struct TREE_DISCONNECT_Request
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 4, indicating the size of the request structure, not including the header.
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// Reserved (2 bytes): This field MUST NOT be used and MUST be reserved. The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        public UInt16 Reserved => 0;
    }
}
