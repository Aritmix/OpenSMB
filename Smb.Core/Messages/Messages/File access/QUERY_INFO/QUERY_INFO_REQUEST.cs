using Smb.Core.Models;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class QUERY_INFO_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 41;
        /// <summary>
        /// </summary>
        public QUERY_INFO_REQUEST_INFO_TYPES InfoType;
        public FILE_INFORMATION_CLASS FileInfoClass;
        public UInt32 OutputBufferLength;
        public UInt16 InputBufferOffset;
        public UInt16 Reserved => 0;
        public UInt32 InputBufferLength;
        public QUERY_INFO_REQUEST_ADDITIONAL_INFO AdditionalInformation;
        public QUERY_INFO_REQUEST_FLAGS Flags;

        public FILEID FileId;
        public FILE_GET_EA_INFORMATION[] Buffer;
    }

    internal enum QUERY_INFO_REQUEST_INFO_TYPES : Byte
    {
        SMB2_0_INFO_FILE = 0x01,
        SMB2_0_INFO_FILESYSTEM = 0x02,
        SMB2_0_INFO_SECURITY = 0x03,
        SMB2_0_INFO_QUOTA = 0x04,
    }

    internal enum QUERY_INFO_REQUEST_ADDITIONAL_INFO : UInt32
    {
        OWNER_SECURITY_INFORMATION = 0x00000001,
        GROUP_SECURITY_INFORMATION = 0x00000002,
        DACL_SECURITY_INFORMATION = 0x00000004,
        SACL_SECURITY_INFORMATION = 0x00000008,
        LABEL_SECURITY_INFORMATION = 0x00000010,
        ATTRIBUTE_SECURITY_INFORMATION = 0x00000020,
        SCOPE_SECURITY_INFORMATION = 0x00000040,
        BACKUP_SECURITY_INFORMATION = 0x00010000,
    }

    internal enum QUERY_INFO_REQUEST_FLAGS : UInt32
    {
        SL_RESTART_SCAN = 0x00000001,
        SL_RETURN_SINGLE_ENTRY = 0x00000002,
        SL_INDEX_SPECIFIED = 0x00000004,
    }
}
