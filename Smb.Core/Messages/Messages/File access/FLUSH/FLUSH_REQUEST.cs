using Smb.Core.Models;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Request packet is sent by the client to request termination of a particular session. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class FLUSH_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 24;
        /// <summary>
        /// </summary>
        public UInt16 Reserved1 => 0;
        public UInt16 Reserved2 => 0;
        public FILEID FileId;
    }
}
