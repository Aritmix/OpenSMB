using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2_NETNAME_NEGOTIATE_CONTEXT_ID context is specified in an SMB2 NEGOTIATE request to indicate the server name the client connects to. The format of the data in the Data field of this SMB2_NEGOTIATE_CONTEXT is as follows.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal struct NETNAME_NEGOTIATE_CONTEXT_ID : ICapability
    {
        /// <summary>
        /// NetName (variable): A Unicode string containing the server name and specified by the client application.
        /// </summary>
        public String NetName;
    }
}
