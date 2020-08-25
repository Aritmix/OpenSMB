using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_COPYCHUNK_COPY
    {
        /// <summary>
        /// </summary>

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public Byte[] SourceKey;
        /// <summary>
        /// </summary>
        public UInt32 ChunkCount;

        public UInt32 Reserved => 0;

        public SRV_COPYCHUNK_REQUEST[] Chunks;
    }
}
