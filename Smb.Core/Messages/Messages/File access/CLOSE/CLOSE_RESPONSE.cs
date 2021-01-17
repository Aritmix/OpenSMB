using System;
using System.Dynamic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 CLOSE Response packet is sent by the server to indicate that an SMB2 CLOSE Request was processed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this response structure:
    /// </summary>

    internal struct CLOSE_RESPONSE
    {
        /// <summary>
        /// StructureSize (2 bytes): The server MUST set this field to 60, indicating the size of the response structure, not including the header.
        /// </summary>
        public UInt16 StructureSize => 60;
        /// <summary>
        /// Flags (2 bytes): A Flags field indicates how to process the operation. This field MUST be either zero or the following value:
        /// </summary>
        public CloseResponseFlags Flags;

        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. The server MUST set this to 0, and the client MUST ignore it on receipt.
        /// </summary>
        public UInt32 Reserved => 0;

        /// <summary>
        /// CreationTime (8 bytes): The time when the file was created; in FILETIME format as specified in [MS-DTYP] section 2.3.3. If the SMB2_CLOSE_FLAG_POSTQUERY_ATTRIB flag in the SMB2 CLOSE Request was set, this field MUST be set to the value that is returned by the attribute query. If the flag is not set, the field SHOULD be set to zero and MUST NOT be checked on receipt.
        /// </summary>
        public FILETIME CreationTime;
        public FILETIME LastAccessTime;
        public FILETIME LastWriteTime;
        public FILETIME ChangeTime;
        public UInt64 AllocationSize;
        public UInt64 EndofFile;
        public FileAttributes FileAttributes;
    }
    public enum CloseResponseFlags : UInt16
    {
        NONE = 0x0000,
        /// <summary>
        /// If set, the server MUST set the attribute fields in the response, as specified in section 2.2.16, to valid values. If not set, the client MUST NOT use the values that are returned in the response.
        /// </summary>
        SMB2_CLOSE_FLAG_POSTQUERY_ATTRIB = 0x0001,
    }
    
}
