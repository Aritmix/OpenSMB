using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message.Error
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    public class ERROR_RESPONSE
    {
        /// <summary>
        /// The SMB2 ERROR Response packet is sent by the server to respond to a request that has failed or encountered an error. 
        /// This response is composed of an SMB2 Packet Header (section 2.2.1) followed by this response structure.
        /// </summary>
        public UInt16 StructureSize => 9;
        /// <summary>
        /// ErrorContextCount (1 byte): This field MUST be set to 0 for SMB dialects other than 3.1.1. 
        /// For the SMB dialect 3.1.1, if this field is nonzero, the ErrorData field MUST be formatted as a variable-length array of SMB2 ERROR Context structures containing ErrorContextCount entries. 
        /// </summary>
        public Byte ErrorContextCount => 0;
        /// <summary>
        /// Reserved (1 byte): This field MUST NOT be used and MUST be reserved. 
        /// The server MUST set this to 0, and the client MUST ignore it on receipt.
        /// </summary>
        public Byte Reserved => 0;
        /// <summary>
        /// ByteCount (4 bytes): The number of bytes of data contained in ErrorData[].
        /// </summary>
        public UInt32 ByteCount;
        /// <summary>
        /// ErrorData (variable): A variable-length data field that contains extended error information. 
        /// If the ErrorContextCount field in the response is nonzero, this field MUST be formatted as a variable-length array of SMB2 ERROR Context structures as specified in section 2.2.2.1. 
        /// Each SMB2 ERROR Context MUST start at an 8-byte aligned boundary relative to the start of the SMB2 ERROR Response. 
        /// Otherwise, it MUST be formatted as specified in section 2.2.2.2. If the ByteCount field is zero then the server MUST supply an ErrorData field that is one byte in length, 
        /// and SHOULD set that byte to zero; the client MUST ignore it on receipt.<4>
        /// </summary>
        internal ERROR_CONTEXT_RESPONSE[] ErrorData;
    }
}
