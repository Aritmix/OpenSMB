using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class VALIDATE_NEGOTIATE_REQUEST
    {
        public UInt32 Capabilities;
        public GUID Guid;
        public UInt16 SecurityMode;
        public UInt16 DialectCount;
        public Dialects Dialects;
    }
}
