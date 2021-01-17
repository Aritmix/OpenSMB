using Smb.Core.Messages;
using Smb.Core.Session;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Smb.Core.Shared
{
    public class SMBServerConnection
    {
        /// <summary>
        /// Capability flags of the client, as specified in section 2.2.3.
        /// </summary>
        public NegotiateCapabilities ClientCapabilities { get; set; }

        /// <summary>
        /// Sequence number for the next signed request being received.
        /// </summary>
        public uint ServerNextReceiveSequenceNumber { get; set; }

        /// <summary>
        /// The encryption key received, sent by the server during a nonextended security negotiation for use in 
        /// implicit NTLM authentication.
        /// </summary>
        public byte[] ntlmEncryptionKey { get; set; }

        /// <summary>
        /// A table of Sessions established on this connection. The table is searchable based on Session.Uid or Session
        /// .SecurityContext.
        /// </summary>
        public Collection<SMBServerSession> SessionTable { get; set; }

        /// <summary>
        /// A null-terminated Unicode UTF-16 IP address string, or NetBIOS host name of the client machine.
        /// </summary>
        public String ClientName { get; set; }

        /// <summary>
        /// key is the mid, value is the smb packet.
        /// A list of outstanding SMB requests on this connection. Each element in the list is a tuple of the form
        /// [Request, Mid, Pid], where the Request describes an outstanding SMB request as described in section 
        /// 3.3.1.11, the Mid and the Pid refer to the corresponding values obtained from the SMB header of the message
        /// sent by the client.
        /// </summary>
        public Dictionary<UInt16, SMBRequest> RequestList { get; set; }
    }
}
