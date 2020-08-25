using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class FILE_NOTIFY_INFORMATION
    {
        public UInt32 NextEntryOffset;
        public UInt32 Action;
        public UInt32 FileNameLength;
        public String FileName;
    }

    internal enum FILE_NOTIFY_INFORMATION_ACTIONS : UInt32
    {
        FILE_ACTION_ADDED = 0x00000001,
        FILE_ACTION_REMOVED = 0x00000002,
        FILE_ACTION_MODIFIED = 0x00000003,
        FILE_ACTION_RENAMED_OLD_NAME = 0x00000004,
        FILE_ACTION_RENAMED_NEW_NAME = 0x00000005,
        FILE_ACTION_ADDED_STREAM = 0x00000006,
        FILE_ACTION_REMOVED_STREAM = 0x00000007,
        FILE_ACTION_MODIFIED_STREAM = 0x00000008,
        FILE_ACTION_REMOVED_BY_DELETE = 0x00000009,
        FILE_ACTION_ID_NOT_TUNNELLED = 0x0000000A,
        FILE_ACTION_TUNNELLED_ID_COLLISION = 0x0000000B
    }
}
