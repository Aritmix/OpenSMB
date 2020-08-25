using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 CLOSE Request packet is used by the client to close an instance of a file that was opened previously with a successful SMB2 CREATE Request. This request is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CLOSE_REQUEST
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 24, indicating the size of the request structure, not including the header.
        /// </summary>
        public UInt16 StructureSize => 24;
        /// <summary>
        /// Flags (2 bytes): A Flags field indicates how to process the operation. This field MUST be constructed using the following value:
        /// </summary>
        public CloseRequestFlags Flags;

        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        public UInt32 Reserved => 0;

        /// <summary>
        /// FileId (16 bytes): An SMB2_FILEID structure, as specified in section 2.2.14.1.
        /// The identifier of the open to a file or named pipe that is being closed.
        /// </summary>
        public FILEID FileId;
    }
    /// <summary>
    /// Flags (2 bytes): A Flags field indicates how to process the operation. This field MUST be constructed using the following value:
    /// </summary>
    internal enum CloseRequestFlags : UInt16
    {
        /// <summary>
        /// If set, the server MUST set the attribute fields in the response, as specified in section 2.2.16, to valid values. If not set, the client MUST NOT use the values that are returned in the response.
        /// </summary>
        SMB2_CLOSE_FLAG_POSTQUERY_ATTRIB = 0x0001,
    }
}
