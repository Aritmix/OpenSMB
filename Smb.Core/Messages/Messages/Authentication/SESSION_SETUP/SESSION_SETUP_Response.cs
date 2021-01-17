using System;
using System.Dynamic;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 SESSION_SETUP Response packet is sent by the server in response to an SMB2 SESSION_SETUP Request packet. This response is composed of an SMB2 header, as specified in section 2.2.1, that is followed by this response structure:
    /// </summary>
    internal class SESSION_SETUP_Response
    {
        /// <summary>
        /// StructureSize (2 bytes): The server MUST set this to 9, indicating the size of the fixed part of the response structure not including the header. The server MUST set it to this value regardless of how long Buffer[] actually is in the response.
        /// </summary>
        public UInt16 StructureSize => 9;
        /// <summary>
        /// Flags (1 byte): If the client implements the SMB 3.x dialect family, this field MUST be set to combination of zero or more of the following values. Otherwise, it MUST be set to 0.
        /// </summary>
        public SessionSetupResponseFlags SessionFlags => 0;

        /// <summary>
        /// SecurityBufferOffset (2 bytes): The offset, in bytes, from the beginning of the SMB 2 Protocol header to the security buffer.
        /// </summary>
        public UInt16 SecurityBufferOffset;

        /// <summary>
        /// SecurityBufferLength (2 bytes): The length, in bytes, of the security buffer.
        /// </summary>
        public UInt16 SecurityBufferLength => (UInt16)Buffer?.Length;

        /// <summary>
        /// Buffer (variable): A variable-length buffer that contains the security buffer for the response, as specified by SecurityBufferOffset and SecurityBufferLength. If the server initiated authentication using SPNEGO, the buffer MUST contain a token as produced by the GSS protocol as specified in section 3.3.5.5.3. If the client initiated authentication, see section 2.2.4, the buffer SHOULD<25> contain a token as produced by an authentication protocol of the client's choice.
        /// </summary>
        public Byte[] Buffer;

    }
}
