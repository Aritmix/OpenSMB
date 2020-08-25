using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class ECHO_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// </summary>
        public UInt32 Reserved => 0;
    }
}
