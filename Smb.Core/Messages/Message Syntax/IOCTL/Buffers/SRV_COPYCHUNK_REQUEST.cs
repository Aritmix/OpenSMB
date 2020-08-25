using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_COPYCHUNK_REQUEST
    {
        public UInt64 SourceOffset;
        public UInt64 TargetOffset;
        public UInt32 Length;
        public UInt32 Reserved => 0;
    }
}
