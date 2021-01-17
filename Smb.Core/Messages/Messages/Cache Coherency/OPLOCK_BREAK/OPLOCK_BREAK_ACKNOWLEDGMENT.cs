using Smb.Core.Models;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class OPLOCK_BREAK_ACKNOWLEDGMENT
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 24;
        /// <summary>
        /// </summary>
        public OPLOCK_BREAK_ACKNOWLEDGMENT_LEVELS OplockLevel;

        public Byte Reserved => 0;
        public UInt32 Reserved2 => 0;
        public FILEID FileId;
    }

    internal enum OPLOCK_BREAK_ACKNOWLEDGMENT_LEVELS : Byte
    {
        /// <summary>
        /// No oplock is available.
        /// </summary>
        SMB2_OPLOCK_LEVEL_NONE = 0x00,
        /// <summary>
        /// A level II oplock is available.
        /// </summary>
        SMB2_OPLOCK_LEVEL_II = 0x01
    }
}
