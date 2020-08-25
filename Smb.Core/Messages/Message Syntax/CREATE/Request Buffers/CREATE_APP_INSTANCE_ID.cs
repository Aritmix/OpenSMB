using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_APP_INSTANCE_ID : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_REQUEST_BUFFER_NAMES.CREATE_APP_INSTANCE_ID;

        public UInt16 StructureSize;
        public UInt16 Reserved => 0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] AppInstanceId;
    }
}
