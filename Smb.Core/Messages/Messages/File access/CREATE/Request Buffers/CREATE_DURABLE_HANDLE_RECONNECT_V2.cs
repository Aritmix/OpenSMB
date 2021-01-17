using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using Smb.Core.Models;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_DURABLE_HANDLE_RECONNECT_V2 : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_DURABLE_HANDLE_RECONNECT_V2;

        public FILEID FileId;
        public GUID CreateGuid;
        public ReconnectFlags Flags;
    }
    public enum ReconnectFlags : UInt32
    {
        NONE = 0x00000000,
        SMB2_DHANDLE_FLAG_PERSISTENT = 0x00000002
    }
}
