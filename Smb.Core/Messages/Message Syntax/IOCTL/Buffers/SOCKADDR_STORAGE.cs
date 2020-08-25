using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SOCKADDR_STORAGE
    {
        public SOCKADDR_STORAGE_FAMILY Family;
        public SOCKADDR_IN Buffer;
        public Byte[] Reserved;
    }
    internal enum SOCKADDR_STORAGE_FAMILY : UInt16
    {
        InterNetwork = 0x0002,
        InterNetworkV6 = 0x0017
    }
}
