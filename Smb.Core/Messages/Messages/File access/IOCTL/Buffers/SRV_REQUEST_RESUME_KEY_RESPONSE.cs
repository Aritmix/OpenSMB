using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_REQUEST_RESUME_KEY_RESPONSE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public Byte[] ResumeKey;
        public UInt32 ContextLength => 0;

        //TODO: Byte[] => Context
        public Byte[] Context;
    }
}
