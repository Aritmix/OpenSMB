using Smb.Core.Models;
using Smb.Core.Shared;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    public class VALIDATE_NEGOTIATE_RESPONSE
    {
        public UInt32 Capabilities;
        public GUID Guid;
        public UInt16 SecurityMode;
        public SMBDialects Dialects;
    }
}
