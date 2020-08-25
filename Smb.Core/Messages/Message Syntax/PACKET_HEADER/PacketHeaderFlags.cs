﻿using System;

namespace Smb.Core
{

    /// <summary>
    /// Flags (4 bytes): A flags field, which indicates how to process the operation. This field MUST be constructed using the following values:
    /// </summary>
    [Flags]
    public enum PacketHeaderFlags : UInt32
    {
        /// <summary>
        /// When set, indicates the message is a response, rather than a request. This MUST be set on responses sent from the server to the client and MUST NOT be set on requests sent from the client to the server.
        /// </summary>
        FLAGS_SERVER_TO_REDIR = 0x0000001,
        /// <summary>
        /// When set, indicates that this is an ASYNC SMB2 header. This flag MUST NOT be set when using the SYNC SMB2 header.
        /// </summary>
        FLAGS_ASYNC_COMMAND = 0x0000002,
        /// <summary>
        /// When set in an SMB2 request, indicates that this request is a related operation in a compounded request chain. The use of this flag in an SMB2 request is as specified in section 3.2.4.1.4.
        /// When set in an SMB2 compound response, indicates that the request corresponding to this response was part of a related operation in a compounded request chain. The use of this flag in an SMB2 response is as specified in section 3.3.5.2.7.2.
       /// </summary>
        FLAGS_RELATED_OPERATIONS = 0x0000004,
        /// <summary>
        /// When set, indicates that this packet has been signed. The use of this flag is as specified in section 3.1.5.1.
        /// </summary>
        FLAGS_SIGNED = 0x0000008,
        /// <summary>
        /// This flag is only valid for the SMB 3.1.1 dialect. It is a mask for the requested I/O priority of the request, and it MUST be a value in the range 0 to 7.
        /// </summary>
        FLAGS_PRIORITY_MASK = 0x00000070,
        /// <summary>
        /// When set, indicates that this command is a DFS operation. The use of this flag is as specified in section 3.3.5.9.
        /// </summary>
        FLAGS_DFS_OPERATIONS = 0x10000000,
        /// <summary>
        /// This flag is only valid for the SMB 3.x dialect family. When set, it indicates that this command is a replay operation.
        /// The client MUST ignore this bit on receipt.
        /// </summary>
        FLAGS_REPLAY_OPERATION = 0x20000000,
    }
}
