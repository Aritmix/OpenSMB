using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_ALLOCATION_SIZE : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_ALLOCATION_SIZE;

        public UInt64 AllocationSize;
    }
}
