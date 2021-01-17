using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Request packet is sent by the client to request termination of a particular session. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SMB2_LOCK_ELEMENT
    {
        /// <summary>
        /// </summary>
        public UInt64 Offset => 48;
        /// <summary>
        /// </summary>
        public UInt64 Length;
        public SMB2_LOCK_ELEMENT_FLAGS Flags;
        public UInt32 Reserved;
    }

    [Flags]
    internal enum SMB2_LOCK_ELEMENT_FLAGS : UInt32
    {
        SMB2_LOCKFLAG_SHARED_LOCK = 0x00000001,
        SMB2_LOCKFLAG_EXCLUSIVE_LOCK = 0x00000002,
        SMB2_LOCKFLAG_UNLOCK = 0x00000004,
        SMB2_LOCKFLAG_FAIL_IMMEDIATELY = 0x00000010,
    }
}
