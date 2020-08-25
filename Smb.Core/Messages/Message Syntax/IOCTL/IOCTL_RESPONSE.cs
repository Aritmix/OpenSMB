using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class IOCTL_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 49;
        /// <summary>
        /// </summary>
        public UInt16 Reserved => 0;

        public CtlCodes CtlCode;

        public FILEID FileId;

        public UInt32 InputOffset;
        public UInt32 InputCount;
        public UInt32 OutputOffset;
        public UInt32 OutputCount;
        public UInt32 Flags => 0;
        public UInt32 Reserved2 => 0;
        public Byte[] Buffer;
    }
}
