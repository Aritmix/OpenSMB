using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class QUERY_DIRECTORY_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 33;
        /// <summary>
        /// </summary>
        public QUERY_DIRECTORY_REQUEST_FILE_INFO FileInformationClass;

        public QUERY_DIRECTORY_REQUEST_FLAGS Flags;
        public UInt32 FileIndex;
        public FILEID FileId;
        public UInt16 FileNameOffset;
        public UInt16 FileNameLength => (UInt16)Buffer?.Length;
        public UInt32 OutputBufferLength;
        /// <summary>
        /// Buffer (variable): A variable-length buffer containing the Unicode search pattern for the request, as described by the FileNameOffset and FileNameLength fields. 
        /// The format, including wildcards and other conventions for this pattern, is specified in [MS-CIFS] section 2.2.1.1.3.<65>
        /// </summary>
        public String Buffer;
    }

    internal enum QUERY_DIRECTORY_REQUEST_FILE_INFO : Byte
    {
        FileDirectoryInformation = 0x01,
        FileFullDirectoryInformation = 0x02,
        FileIdFullDirectoryInformation = 0x26,
        FileBothDirectoryInformation = 0x03,
        FileIdBothDirectoryInformation = 0x25,
        FileNamesInformation = 0x0C,
    }
    [Flags]
    internal enum QUERY_DIRECTORY_REQUEST_FLAGS : Byte
    {
        NONE = 0x00,
        SMB2_RESTART_SCANS = 0x01,
        SMB2_RETURN_SINGLE_ENTRY = 0x02,
        SMB2_INDEX_SPECIFIED = 0x04,
        SMB2_REOPEN = 0x10,
    }
}
