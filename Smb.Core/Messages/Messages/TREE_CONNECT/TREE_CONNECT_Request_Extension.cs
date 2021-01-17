using System;
using System.Dynamic;

namespace Smb.Core.Messages
{
    /// <summary>
    /// If the Flags field of the SMB2 TREE_CONNECT request has the SMB2_TREE_CONNECT_FLAG_EXTENSION_PRESENT bit set, the following structure MUST be added at the beginning of the Buffer field.
    /// </summary>
    internal struct TREE_CONNECT_Request_Extension
    {
        /// <summary>
        /// TreeConnectContextOffset (4 bytes): The offset from the start of the SMB2 TREE_CONNECT request of an array of tree connect contexts.
        /// </summary>
        public UInt32 TreeConnectContextOffset;
        /// <summary>
        /// TreeConnectContextCount(2 bytes) : The count of elements in the tree connect context array.        
        /// </summary>
        public UInt16 TreeConnectContextCount => (UInt16)TreeConnectContexts?.Length;
        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. This value MUST be set to 0 by the client, and MUST be ignored by the server.
        /// </summary>
        public  UInt32[] Reserved => new UInt32[10];
        /// <summary>
        /// PathName (variable): This field is a variable-length buffer that contains the full share path name as specified in section 2.2.9.
        /// </summary>
        public Byte[] PathName;

        /// <summary>
        /// TreeConnectContexts (variable): A variable length array of SMB2_TREE_CONNECT_CONTEXT structures as described in section 2.2.9.2.
        /// </summary>
        public TREE_CONNECT_CONTEXT_Request_Values[] TreeConnectContexts;
        
    }

    
}
