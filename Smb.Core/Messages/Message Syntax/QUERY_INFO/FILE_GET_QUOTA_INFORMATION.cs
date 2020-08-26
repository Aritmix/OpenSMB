using System;

namespace Smb.Core
{
    public class FILE_GET_QUOTA_INFORMATION
    {
        public UInt32 NextEntryOffset;
        public UInt32 SidLength => (UInt32)Sid?.Length;
        public Byte[] Sid;
    }
}