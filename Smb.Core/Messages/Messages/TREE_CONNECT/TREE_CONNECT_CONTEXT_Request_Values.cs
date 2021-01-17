using System;
using System.Dynamic;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2_TREE_CONNECT_CONTEXT structure is used by the SMB2 TREE_CONNECT request and the SMB2 TREE_CONNECT response to encode additional properties.
    /// </summary>
    internal struct TREE_CONNECT_CONTEXT_Request_Values
    {
        /// <summary>
        /// ContextType (2 bytes): Specifies the type of context in the Data field. This field MUST be one of the following values:
        /// </summary>
        public TreeConnectContextType ContextType;
        /// <summary>
        /// DataLength (2 bytes): The length, in bytes, of the Data field.
        /// </summary>
        public UInt16 DataLength => (UInt16)Data?.Length;
        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. This value MUST be set to 0 by the client, and MUST be ignored by the server.
        /// </summary>
        public UInt32 Reserved => 0;
        /// <summary>
        /// Data (variable): A variable-length field that contains the tree connect context specified by the ContextType field.
        /// </summary>
        public Byte[] Data;
    }
}
