using Smb.Core.Models;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SOCKADDR_IN6
    {
        public UInt16 Port;
        public UInt32 FlowInfo;

        public IPvxAddress IPv6Address;
        public UInt64 ScopeId => 0;
    }
}
