using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{

    /// <summary>
    /// and responses.
    /// There are two variants of this header:
    /// + ASYNC
    /// + SYNC
    /// If the SMB2_FLAGS_ASYNC_COMMAND bit is set in Flags, the header takes the form SMB2 Packet Header – ASYNC (section 2.2.1.1). This header format is used for responses to requests processed asynchronously by the server, as specified in sections 3.3.4.2, 3.3.4.3, 3.3.4.4, and 3.2.5.1.5. The SMB2 CANCEL Request MUST use this format for canceling requests that have received an interim response, as specified in sections 3.2.4.24 and 3.3.5.16. 
    /// If the SMB2_FLAGS_ASYNC_COMMAND bit is not set in Flags, the header takes the form SMB2 Packet Header – SYNC(section 2.2.1.2).
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct PacketProtocolHeader
    {
        /// <summary>
        /// <b>2.2.1.1	SMB2 Packet Header - ASYNC</b>
        /// AsyncId (8 bytes): A unique identification number that is created by the server to handle operations asynchronously, as specified in section 3.3.4.2.
        /// </summary>
        [FieldOffset(0)] public UInt64 AsyncId;
        /// <summary>
        /// <b>2.2.1.2	SMB2 Packet Header - SYNC</b>
        /// Reserved (4 bytes): The client SHOULD (Windows clients set this field to 0xFEFF.) set this field to 0.
        /// The server MAY(Windows servers do not use this field in the request processing and return the value received in the request) ignore this field on receipt.
        /// </summary>
        [FieldOffset(0)] public UInt32 Reserved;
        /// <summary>
        /// <b>2.2.1.2	SMB2 Packet Header - SYNC</b>
        /// TreeId (4 bytes): Uniquely identifies the tree connect for the command. This MUST be 0 for the SMB2 TREE_CONNECT Request. The TreeId can be any unsigned 32-bit integer that is received from a previous SMB2 TREE_CONNECT Response. 
        /// TreeId SHOULD be set to 0 for the following commands:
        /// - SMB2 NEGOTIATE Request
        /// - SMB2 NEGOTIATE Response
        /// - SMB2 SESSION_SETUP Request
        /// - SMB2 SESSION_SETUP Response
        /// - SMB2 LOGOFF Request
        /// - SMB2 LOGOFF Response
        /// - SMB2 ECHO Request
        /// - SMB2 ECHO Response
        /// - SMB2 CANCEL Request
        /// </summary>
        [FieldOffset(sizeof(UInt32))] public UInt32 TreeId;   
    }
}
