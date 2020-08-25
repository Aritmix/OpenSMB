using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 SESSION_SETUP Request packet is sent by the client to request a new authenticated session within a new or existing SMB 2 Protocol transport connection to the server. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    internal class SESSION_SETUP_Request
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 25, indicating the size of the request structure, not including the header. The client MUST set it to this value regardless of how long Buffer[] actually is in the request being sent.
        /// </summary>
        public UInt16 StructureSize => 25;
        /// <summary>
        /// Flags (1 byte): If the client implements the SMB 3.x dialect family, this field MUST be set to combination of zero or more of the following values. Otherwise, it MUST be set to 0.
        /// </summary>
        public SessionSetupFlags Flags => 0;
        /// <summary>
        /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client
        /// </summary>
        public SessionSetupSecurityModes SecurityMode;
        /// <summary>
        /// Capabilities (4 bytes): Specifies protocol capabilities for the client. This field MUST be constructed using the following values.
        /// </summary>
        public SessionSetupCapabilities Capabilities;
        /// <summary>
        /// Channel (4 bytes): This field MUST NOT be used and MUST be reserved. The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        public UInt32 Channel => 0;

        /// <summary>
        /// SecurityBufferOffset (2 bytes): The offset, in bytes, from the beginning of the SMB 2 Protocol header to the security buffer.
        /// </summary>
        public UInt16 SecurityBufferOffset;

        /// <summary>
        /// SecurityBufferLength (2 bytes): The length, in bytes, of the security buffer.
        /// </summary>
        public UInt16 SecurityBufferLength => (UInt16)Buffer?.Length;

        /// <summary>
        /// PreviousSessionId (8 bytes): A previously established session identifier. The server uses this value to identify the client session that was disconnected due to a network error.
        /// </summary>
        public UInt64 PreviousSessionId;

        /// <summary>
        /// Buffer (variable): A variable-length buffer that contains the security buffer for the request, as specified by SecurityBufferOffset and SecurityBufferLength. If the server initiated authentication using SPNEGO, the buffer MUST contain a token as produced by the GSS protocol as specified in section 3.2.4.2.3. If the client initiated authentication, see section 2.2.4, the buffer SHOULD<24> contain a token as produced by an authentication protocol of the client's choice.
        /// </summary>
        public Byte[] Buffer;

    }
}
