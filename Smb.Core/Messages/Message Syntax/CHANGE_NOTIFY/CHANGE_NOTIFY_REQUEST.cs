using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CHANGE_NOTIFY_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 32;
        /// <summary>
        /// </summary>
        public CHANGE_NOTIFY_REQUEST_FLAGS Flags;
        public UInt32 OutputBufferLength;
        public FILEID FileId;
        public CHANGE_NOTIFY_REQUEST_COMPLITION_FILTERS CompletionFilter;
        public UInt32 Reserved => 0;
    }

    [Flags]
    internal enum CHANGE_NOTIFY_REQUEST_COMPLITION_FILTERS : UInt32
    {
        FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001,
        FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002,
        FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004,
        FILE_NOTIFY_CHANGE_SIZE = 0x00000008,
        FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010,
        FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020,
        FILE_NOTIFY_CHANGE_CREATION = 0x00000040,
        FILE_NOTIFY_CHANGE_EA = 0x00000080,
        FILE_NOTIFY_CHANGE_SECURITY = 0x00000100,
        FILE_NOTIFY_CHANGE_STREAM_NAME = 0x00000200,
        FILE_NOTIFY_CHANGE_STREAM_SIZE = 0x00000400,
        FILE_NOTIFY_CHANGE_STREAM_WRITE = 0x00000800,
    }

    [Flags]
    internal enum CHANGE_NOTIFY_REQUEST_FLAGS : UInt16
    {
        NONE = 0x0000,
        SMB2_WATCH_TREE = 0x0001,
    }
}
