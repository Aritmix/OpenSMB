using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{

    /// <summary>
    /// (ChannelSequence/Reserved)/Status (4 bytes): 
    /// In a request, this field is interpreted in different ways depending on the SMB2 dialect.
    /// In the SMB 3.x dialect family, this field is interpreted as the ChannelSequence field followed by the Reserved field in a request.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct PacketHeaderStatus
    {
        /// <summary>
        /// In the SMB 2.0.2 and SMB 2.1 dialects, this field is interpreted as the Status field in a request.
        /// Status(4 bytes) : The client MUST set this field to 0 and the server MUST ignore it on receipt.
        /// In all SMB dialects for a response this field is interpreted as the Status field.This field can be set to any value. For a list of valid status codes, see[MS - ERREF] section 2.3.
        /// </summary>
        [FieldOffset(0)] public UInt32 Status;
        /// <summary>
        /// ChannelSequence (2 bytes): This field is an indication to the server about the client's Channel change. 
        /// </summary>
        [FieldOffset(0)] public UInt16 ChannelSequence;
        /// <summary>
        /// Reserved (2 bytes): This field SHOULD be set to zero and the server MUST ignore it on receipt. 
        /// </summary>
        [FieldOffset(2)] public UInt16 Reserved;
    }
}
