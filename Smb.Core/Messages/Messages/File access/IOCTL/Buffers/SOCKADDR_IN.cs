using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SOCKADDR_IN
    {
        public UInt16 Port;
        public UInt32 IPv4Address;
        public UInt64 Reserved;
    }
}
