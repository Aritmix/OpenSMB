using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class NETWORK_INTERFACE_INFO_RESPONSE
    {
        public UInt32 Next;
        public UInt32 IfIndex;
        public UInt32 Capability;
        public UInt32 Reserved => 0;
        public UInt64 LinkSpeed;
        public SOCKADDR_STORAGE SockAddr_Storage;
    }
}
