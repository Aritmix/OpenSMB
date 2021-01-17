using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using Smb.Core.Models;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_DURABLE_HANDLE_REQUEST_V2 : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_DURABLE_HANDLE_REQUEST_V2;

        public UInt32 Timeout;
        public DURABLE_HANDLE_REQUEST_FLAGS Flags;
        public UInt64 Reserved => 0;
        public GUID CreateGuid;
        
    }
    public enum DURABLE_HANDLE_REQUEST_FLAGS : UInt32
    {
        None = 0x00000000,
        /// <summary>
        /// A persistent handle is requested.
        /// </summary>
        SMB2_DHANDLE_FLAG_PERSISTENT = 0x00000002
    }
}
