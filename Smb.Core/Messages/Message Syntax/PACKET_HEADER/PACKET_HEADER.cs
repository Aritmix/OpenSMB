using System;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message.Packet
{
    [StructLayout(layoutKind:LayoutKind.Sequential)]
    public class PACKET_HEADER : PacketHeaderBase
    {
        public PACKET_HEADER()
        {
            Signature = new Byte[16];
        }
        /// <summary>
        /// StructureSize (2 bytes): MUST be set to 64, which is the size, in bytes, of the SMB2 header structure.
        /// </summary>
        public ushort StructureSize => 64;
        /// <summary>
        /// CreditCharge (2 bytes): In the SMB 2.0.2 dialect, this field MUST NOT be used and MUST be reserved. The sender MUST set this to 0, and the receiver MUST ignore it. 
        /// In all other dialects, this field indicates the number of credits that this request consumes.
        /// </summary>
        public ushort CreditCharge => 0;
        /// <summary>
        /// (ChannelSequence/Reserved)/Status (4 bytes): In a request, this field is interpreted in different ways depending on the SMB2 dialect.
        /// In the SMB 3.x dialect family, this field is interpreted as the ChannelSequence field followed by the Reserved field in a request.
        /// <b>ChannelSequence(2 bytes) :</b> This field is an indication to the server about the client's Channel change. 
        /// <b>Reserved(2 bytes) : </b>This field SHOULD be set to zero and the server MUST ignore it on receipt.
        /// In the SMB 2.0.2 and SMB 2.1 dialects, this field is interpreted as the Status field in a request.
        /// <b>Status(4 bytes): </b>The client MUST set this field to 0 and the server MUST ignore it on receipt.
        /// In all SMB dialects for a response this field is interpreted as the Status field.This field can be set to any value. For a list of valid status codes, see[MS - ERREF] section 2.3.
        /// </summary>
        public PacketHeaderStatus Status;
        /// <summary>
        ///  The command code of this packet.
        /// </summary>
        public PacketHeaderCommands Command;
        /// <summary>
        /// CreditRequest/CreditResponse (2 bytes): On a request, this field indicates the number of credits the client is requesting. 
        /// On a response, it indicates the number of credits granted to the client. 
        /// </summary>
        public UInt16 Credits;
        /// <summary>
        /// Flags (4 bytes): A flags field, which indicates how to process the operation. 
        /// This field MUST be constructed using the following values:
        /// </summary>
        public PacketHeaderFlags Flags;
        /// <summary>
        /// NextCommand (4 bytes): For a compounded request and response, this field MUST be set to the offset, in bytes, from the beginning of this SMB2 header to the start of the subsequent 8-byte aligned SMB2 header. 
        /// If this is not a compounded request or response, or this is the last header in a compounded request or response, this value MUST be 0
        /// </summary>
        public UInt32 NextCommand;

        /// <summary>
        /// MessageId (8 bytes): A value that identifies a message request and response uniquely across all messages that are sent on the same SMB 2 Protocol transport connection.
        /// </summary>
        public UInt64 MessageId;
        /// <summary>
        ///  The SMB2 Packet Header(also called the SMB2 header) is the header of all SMB 2 Protocol requests and responses.
        ///  There are two variants of this header:
        ///  + ASYNC
        ///  + SYNC
        ///  If the SMB2_FLAGS_ASYNC_COMMAND bit is set in Flags, the header takes the form SMB2 Packet Header – ASYNC (section 2.2.1.1). This header format is used for responses to requests processed asynchronously by the server, as specified in sections 3.3.4.2, 3.3.4.3, 3.3.4.4, and 3.2.5.1.5. The SMB2 CANCEL Request MUST use this format for canceling requests that have received an interim response, as specified in sections 3.2.4.24 and 3.3.5.16. 
        ///  If the SMB2_FLAGS_ASYNC_COMMAND bit is not set in Flags, the header takes the form SMB2 Packet Header – SYNC(section 2.2.1.2).
        /// </summary>
        public PacketProtocolHeader PacketProtocolHeader; 
        /// <summary>
        /// SessionId (8 bytes): Uniquely identifies the established session for the command. 
        /// This field MUST be set to 0 for an SMB2 NEGOTIATE Request (section 2.2.3) and for an SMB2 NEGOTIATE Response (section 2.2.4). 
        /// </summary>
        public UInt64 SessionId;
        /// <summary>
        /// SessionId (8 bytes): Uniquely identifies the established session for the command. 
        /// This field MUST be set to 0 for an SMB2 NEGOTIATE Request (section 2.2.3) and for an SMB2 NEGOTIATE Response (section 2.2.4). 
        /// </summary>
        /// //SMB2_FLAGS_SIGNED 

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] Signature;

        //public bool IsResponse => Flags.HasFlag(PacketHeaderFlags.FLAGS_SERVER_TO_REDIR);
        //public Boolean Async => Flags.HasFlag(PacketHeaderFlags.FLAGS_ASYNC_COMMAND);
        //public Boolean RelatedOperations => Flags.HasFlag(PacketHeaderFlags.FLAGS_RELATED_OPERATIONS);
        //public Boolean Signed => Flags.HasFlag(PacketHeaderFlags.FLAGS_SIGNED);
    }
}
