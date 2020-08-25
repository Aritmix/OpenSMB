using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_DURABLE_HANDLE_RESPONSE : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_RESPONSE_BUFFER_NAMES.CREATE_DURABLE_HANDLE_RESPONSE;
        public UInt64 Reserved => 0;
    }
}
