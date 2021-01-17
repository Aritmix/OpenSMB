using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class WRITE_RESPONSE
    {
        public UInt16 StructureSize => 17;
        public UInt16 Reserved => 0;
        public UInt32 Count;
        public UInt32 Remaining;
        public UInt16 WriteChannelInfoOffset;
        public UInt16 WriteChannelInfoLength;
    }
}
