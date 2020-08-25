using Smb.Core.Messages.Message_Syntax.CREATE;
using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Dynamic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core
{
    internal enum OplockLevels : Byte
    {
        /// <summary>
        /// No oplock is requested.
        /// </summary>
        SMB2_OPLOCK_LEVEL_NONE = 0x00,

        /// <summary>
        /// A level II oplock is requested.
        /// </summary>
        SMB2_OPLOCK_LEVEL_II = 0x01,
        /// <summary>
        /// An exclusive oplock is requested.
        /// </summary>
        SMB2_OPLOCK_LEVEL_EXCLUSIVE = 0x08,
        /// <summary>
        /// A batch oplock is requested.
        /// </summary>
        SMB2_OPLOCK_LEVEL_BATCH = 0x09,
        /// <summary>
        /// A lease is requested. If set, the request packet MUST contain an SMB2_CREATE_REQUEST_LEASE (section 2.2.13.2.8) create context. 
        /// This value is not valid for the SMB 2.0.2 dialect.
        /// </summary>
        SMB2_OPLOCK_LEVEL_LEASE = 0xFF,
    }
    internal enum ImpersonationLevels : UInt32
    {
        /// <summary>
        /// The application-requested impersonation level is Anonymous.
        /// </summary>
        Anonymous = 0x00000000,
        /// <summary>
        /// The application-requested impersonation level is Identification.
        /// </summary>
        Identification = 0x00000001,
        /// <summary>
        ///  The application-requested impersonation level is Impersonation.
        /// </summary>
        Impersonation = 0x00000002,
        /// <summary>
        /// The application-requested impersonation level is Delegate.
        /// </summary>
        Delegate = 0x00000003,
    }
    internal enum ShareAccess : UInt32
    {
        /// <summary>
        ///  When set, indicates that other opens are allowed to read this file while this open is present. This bit MUST NOT be set for a named pipe or a printer file. Each open creates a new instance of a named pipe. Likewise, opening a printer file always creates a new file.
        /// </summary>
        FILE_SHARE_READ = 0x00000000,
        /// <summary>
        /// When set, indicates that other opens are allowed to write this file while this open is present. This bit MUST NOT be set for a named pipe or a printer file. Each open creates a new instance of a named pipe. Likewise, opening a printer file always creates a new file.
        /// </summary>
        FILE_SHARE_WRITE = 0x00000002,
        /// <summary>
        ///  When set, indicates that other opens are allowed to delete or rename this file while this open is present. This bit MUST NOT be set for a named pipe or a printer file. Each open creates a new instance of a named pipe. Likewise, opening a printer file always creates a new file.
        /// </summary>
        FILE_SHARE_DELETE = 0x00000004,
    }

    internal enum CREATE_RESPONSE_FLAGS : Byte
    {
        /// <summary>
        /// </summary>
        NONE = 0x00,
        /// <summary>
        /// </summary>
        SMB2_CREATE_FLAG_REPARSEPOINT = 0x01,
    }
    internal enum CreateActions : UInt32
    {
        /// <summary>
        /// </summary>
        FILE_SUPERSEDED = 0x00000000,
        /// <summary>
        /// </summary>
        FILE_OPENED = 0x00000001,
        /// <summary>
        /// </summary>
        FILE_CREATED = 0x00000002,
        /// <summary>
        /// </summary>
        FILE_OVERWRITTEN = 0x00000003,
    }


    /// <summary>
    /// The SMB2 CREATE Request packet is sent by a client to request either creation of or access to a file. In case of a named pipe or printer, the server MUST create a new file. 
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_RESPONSE
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 36, indicating the size of a NEGOTIATE request. This is not the size of the structure with a single dialect in the Dialects[] array. This value MUST be set regardless of the number of dialects or number of negotiate contexts sent.
        /// </summary>
        public UInt16 StructureSize => 89;

        /// <summary>
        /// </summary>
        public OplockLevels OplockLevel;
        /// <summary>
        /// </summary>
        public CREATE_RESPONSE_FLAGS ImpersonationLevel;
        /// <summary>
        /// </summary>
        public CreateActions CreateActions;
        /// <summary>
        /// </summary>
        public FILETIME CreationTime;
        /// <summary>
        /// </summary>
        public FILETIME LastAccessTime;
        public FILETIME LastWriteTime;
        public FILETIME ChangeTime;

        public UInt64 AllocationSize;
        public UInt64 EndofFile;
        public FileAttributes FileAttributes;

        public Int32 Reserved2 => 0;
        public FILEID FileId;

        public Int32 CreateContextsOffset;
        public Int32 CreateContextsLength;

        public ICreateContextBuffer[] Buffer;
    }
}
