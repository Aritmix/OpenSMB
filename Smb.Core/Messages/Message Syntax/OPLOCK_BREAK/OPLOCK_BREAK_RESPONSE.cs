using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class OPLOCK_BREAK_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 24;
        /// <summary>
        /// </summary>
        public OPLOCK_BREAK_RESPONSE_OPLOCK_LEVELS OplockLevel;

        public Byte Reserved => 0;
        public UInt32 Reserved2 => 0;
        public FILEID FileId;
    }

    internal enum OPLOCK_BREAK_RESPONSE_OPLOCK_LEVELS : Byte
    {
        /// <summary>
        ///  The server has lowered oplock level for this file to none. 
        /// </summary>
        SMB2_OPLOCK_LEVEL_NONE = 0x00,
        /// <summary>
        ///  The server has lowered oplock level for this file to level II. 
        /// </summary>
        SMB2_OPLOCK_LEVEL_II = 0x01
    }
}
