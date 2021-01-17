using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Messages.Message_Syntax.CREATE.CREATE_CONTEXT_Request_Values
{
    internal class CREATE_CONTEXT_RESPONSE
    {
        /// <summary>
        /// Next (4 bytes): The offset from the beginning of this Create Context to the beginning of a subsequent 8-byte aligned Create Context. This field MUST be set to 0 if there are no subsequent contexts.
        /// </summary>
        public UInt32 Next;

        /// <summary>
        /// NameOffset (2 bytes): The offset from the beginning of this structure to its 8-byte aligned name value. 
        /// </summary>
        public UInt16 NameOffset;

        /// <summary>
        /// NameLength (2 bytes): The length, in bytes, of the Create Context name.
        /// </summary>
        public UInt16 NameLength;

        /// <summary>
        /// Reserved (2 bytes): This field MUST NOT be used and MUST be reserved. This value MUST be set to 0 by the client, and ignored by the server.
        /// </summary>
        public UInt16 Reserved => 0;

        /// <summary>
        /// DataOffset (2 bytes): The offset, in bytes, from the beginning of this structure to the 8-byte aligned data payload. If DataLength is 0, the client SHOULD set this value to 0 and the server MUST ignore it on receipt.<46>
        /// </summary>
        public UInt16 DataOffset;
        /// <summary>
        /// DataLength (4 bytes): The length, in bytes, of the data. The format of the data is determined by the type of SMB2_CREATE_CONTEXT request, as outlined in the following sections. The type is inferred from the Create Context name specified by the NameOffset and NameLength fields.
        /// </summary>
        public UInt32 DataLength;
        /// <summary>
        /// Buffer (variable): A variable-length buffer that contains the name and data fields, as defined by NameOffset, NameLength, DataOffset, and DataLength. The name is represented as four or more octets and MUST be one of the values provided in the following table. The structure name indicates what information is encoded by the data payload. The following values are the valid Create Context values and are defined to be in network byte order. More details are provided for each of these values in the following subsections.
        /// vakues: Create_Content_Buffer_names
        /// </summary>
        public ICreateContextBuffer Buffer;
    }
}
