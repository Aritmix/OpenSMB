using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_COPYCHUNK_RESPONSE
    {
        public UInt32 ChunksWritten;
        public UInt32 ChunkBytesWritten;
        public UInt32 TotalBytesWritten;
    }
}
