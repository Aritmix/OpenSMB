using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_QUERY_ON_DISK_ID_RESPONSE : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_RESPONSE_BUFFER_NAMES.CREATE_QUERY_ON_DISK_ID;

        public UInt64 DiskFileId;
        public UInt64 VolumeId;

        public Byte[] Reserved => new Byte[16];

    }
}
