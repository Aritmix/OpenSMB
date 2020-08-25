using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 LOGOFF Request packet is sent by the client to request termination of a particular session. This request is composed of an SMB2 header as specified in section 2.2.1 followed by this request structure.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class LOCK_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 48;
        /// <summary>
        /// </summary>
        public UInt16 LockCount => (UInt16)Locks?.Length;
        public UInt32 LSN;
        public FILEID FileId;
        public SMB2_LOCK_ELEMENT[] Locks;
    }
    internal static class LSN
    {
        public static UInt32 LockSequenceNumber(this UInt32 value)
        {
            return (value & 0xF000) >> 4;
        }
        public static UInt32 LockSequenceIndex(this UInt32 value)
        {
            return (value & 0x0FFF); ;
        }
    }
}
