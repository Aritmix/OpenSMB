using Smb.Core.Models;
using Smb.Core.Shared;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
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
        public SMBDialects Dialects;
    }
}
