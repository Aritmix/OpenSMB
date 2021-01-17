using Smb.Core.Models;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class IOCTL_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// </summary>
        public UInt32 Reserved => 0;

        public CtlCodes CtlCode;

        public FILEID FileId;

        public UInt32 InputOffset;
        public UInt32 InputCount;
        public UInt32 MaxInputResponse;
        public UInt32 OutputOffset => 0;
        public UInt32 OutputCount => 0;
        public UInt32 MaxOutputResponse;
        public IOCRL_REQUEST_FLAGS Flags;
        public UInt32 Reserved2 => 0;

    }
    internal enum IOCRL_REQUEST_FLAGS : UInt32
    {
        SMB2_0_IOCTL = 0x00000000,
        SMB2_0_IOCTL_IS_FSCTL = 0x00000001
    }
    
}
