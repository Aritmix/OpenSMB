using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_QUERY_MAXIMAL_ACCESS_REQUEST : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_QUERY_MAXIMAL_ACCESS_REQUEST;

        public FILETIME Timestamp;
    }
}
