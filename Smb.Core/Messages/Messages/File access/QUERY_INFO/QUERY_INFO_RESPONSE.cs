using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class QUERY_INFO_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 9;
        /// <summary>
        /// </summary>
        public UInt16 OutputBufferOffset;
        public UInt32 OutputBufferLength;
        public Byte[] Buffer;
    }
}
