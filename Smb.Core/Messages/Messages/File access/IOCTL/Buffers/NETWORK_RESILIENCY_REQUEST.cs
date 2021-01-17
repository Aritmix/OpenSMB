using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class NETWORK_RESILIENCY_REQUEST
    {
        public UInt32 Timeout;
        public UInt32 Reserved => 0;
    }
}
