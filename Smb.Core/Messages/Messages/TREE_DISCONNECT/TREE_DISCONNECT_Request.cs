using Smb.Core.Messages;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 TREE_DISCONNECT Request packet is sent by the client to request that the tree connect that is specified in the TreeId within the SMB2 header be disconnected. This request is composed of an SMB2 header, as specified in section 2.2.1, that is followed by this variable-length request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential, Pack = 1)]
    public class TREE_DISCONNECT_Request : SMBSingleRequest
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
