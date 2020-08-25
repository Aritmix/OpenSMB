﻿using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 TREE_DISCONNECT Response packet is sent by the server to confirm that an SMB2 TREE_DISCONNECT Request (section 2.2.11) was successfully processed. This response is composed of an SMB2 header, as specified in section 2.2.1, that is followed by this request structure.
    /// </summary>
    
    internal class TREE_DISCONNECT_Response
    {
        /// <summary>
        /// StructureSize (2 bytes): The server MUST set this field to 4, indicating the size of the response structure, not including the header.
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// Reserved (2 bytes): This field MUST NOT be used and MUST be reserved. The server MUST set this to 0, and the client MUST ignore it on receipt.
        /// </summary>
        public UInt16 Reserved => 0;
    }
}
