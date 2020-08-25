using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_DURABLE_HANDLE_RECONNECT : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_DURABLE_HANDLE_RECONNECT;

        public FILEID Data;
    }
}
