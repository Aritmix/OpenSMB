using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CHANGE_NOTIFY_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 9;
        /// <summary>
        /// </summary>
        public UInt16 OutputBufferOffset;
        public UInt16 OutputBufferLength;
        public FILE_NOTIFY_INFORMATION[] Buffer;
    }
}
