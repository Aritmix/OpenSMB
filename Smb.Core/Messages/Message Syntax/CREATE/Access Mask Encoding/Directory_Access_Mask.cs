using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding
{
    /// <summary>
    /// 2.2.13.1.1	File_Pipe_Printer_Access_Mask
    /// </summary>
    public class File_Pipe_Printer_Access_Mask : IAccess_Mask
    {
        public uint AccessMask { get; }
    }

    internal enum File_Pipe_Printer_Access_Masks : UInt32
    {
        FILE_READ_DATA = 0x00000001,
        FILE_WRITE_DATA = 0x00000002,
        FILE_APPEND_DATA = 0x00000004,
        FILE_READ_EA = 0x00000008,
        FILE_WRITE_EA = 0x00000010,
        FILE_DELETE_CHILD = 0x00000040,
        FILE_EXECUTE = 0x00000020,
        FILE_READ_ATTRIBUTES = 0x00000080,
        DELETE = 0x00010000,
        READ_CONTROL = 0x00020000,
        WRITE_DAC = 0x00040000,
        WRITE_OWNER = 0x00080000,
        SYNCHRONIZE = 0x00100000,
        ACCESS_SYSTEM_SECURITY = 0x01000000,
        MAXIMUM_ALLOWED = 0x02000000,
        GENERIC_ALL = 0x10000000,
        GENERIC_EXECUTE = 0x20000000,
        GENERIC_WRITE = 0x40000000,
        GENERIC_READ = 0x80000000,
    }
}
