using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Request packet is sent by the client to request termination of a particular session. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class LOGOFF_REQUEST
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 4, indicating the size of the request structure not including the header.
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// Reserved (2 bytes): This field MUST NOT be used and MUST be reserved. The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        public UInt16 Reserved => 0;
    }
}
