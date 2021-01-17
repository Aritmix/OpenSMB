using Smb.Core.Messages.Message_Syntax.CREATE;
using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    public enum RequestedOplockLevels : Byte
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
    public enum ImpersonationLevelsRequest : UInt32
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
    public enum ShareAccessRequest : UInt32
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

    public enum CreateDispositionRequest : UInt32
    {
        /// <summary>
        /// </summary>
        FILE_SUPERSEDE = 0x00000000,
        /// <summary>
        /// </summary>
        FILE_OPEN = 0x00000001,
        /// <summary>
        /// </summary>
        FILE_CREATE = 0x00000002,
        /// <summary>
        /// </summary>
        FILE_OPEN_IF = 0x00000003,
        /// <summary>
        /// </summary>
        FILE_OVERWRITE = 0x00000004,
        /// <summary>
        /// </summary>
        FILE_OVERWRITE_IF = 0x00000005,
    }
    public enum CreateOptionsRequest : UInt32
    {
        /// <summary>
        /// </summary>
        FILE_DIRECTORY_FILE = 0x00000001,
        /// <summary>
        /// </summary>
        FILE_WRITE_THROUGH = 0x00000002,
        /// <summary>
        /// </summary>
        FILE_SEQUENTIAL_ONLY = 0x00000004,
        /// <summary>
        /// </summary>
        FILE_NO_INTERMEDIATE_BUFFERING = 0x00000008,
        /// <summary>
        /// </summary>
        FILE_SYNCHRONOUS_IO_ALERT = 0x00000010,
        /// <summary>
        /// </summary>
        FILE_SYNCHRONOUS_IO_NONALERT = 0x00000020,
        /// <summary>
        /// </summary>
        FILE_NON_DIRECTORY_FILE = 0x00000040,
        /// <summary>
        /// </summary>
        FILE_COMPLETE_IF_OPLOCKED = 0x00000100,
        /// <summary>
        /// </summary>
        FILE_NO_EA_KNOWLEDGE = 0x00000200,
        /// <summary>
        /// </summary>
        FILE_RANDOM_ACCESS = 0x00000800,
        /// <summary>
        /// </summary>
        FILE_DELETE_ON_CLOSE = 0x00001000,
        /// <summary>
        /// </summary>
        FILE_OPEN_BY_FILE_ID = 0x00002000,
        /// <summary>
        /// </summary>
        FILE_OPEN_FOR_BACKUP_INTENT = 0x00004000,
        /// <summary>
        /// </summary>
        FILE_NO_COMPRESSION = 0x00008000,
        /// <summary>
        /// </summary>
        FILE_OPEN_REMOTE_INSTANCE = 0x00000400,
        /// <summary>
        /// </summary>
        FILE_OPEN_REQUIRING_OPLOCK = 0x00010000,
        /// <summary>
        /// </summary>
        FILE_DISALLOW_EXCLUSIVE = 0x00020000,
        /// <summary>
        /// </summary>
        FILE_RESERVE_OPFILTER = 0x00100000,
        /// <summary>
        /// </summary>
        FILE_OPEN_REPARSE_POINT = 0x00200000,
        /// <summary>
        /// </summary>
        FILE_OPEN_NO_RECALL = 0x00400000,
        /// <summary>
        /// </summary>
        FILE_OPEN_FOR_FREE_SPACE_QUERY = 0x00800000,
    }


    /// <summary>
    /// The SMB2 CREATE Request packet is sent by a client to request either creation of or access to a file. In case of a named pipe or printer, the server MUST create a new file. 
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_REQUEST
    {
        /// <summary>
        /// StructureSize (2 bytes): The client MUST set this field to 36, indicating the size of a NEGOTIATE request. This is not the size of the structure with a single dialect in the Dialects[] array. This value MUST be set regardless of the number of dialects or number of negotiate contexts sent.
        /// </summary>
        public UInt16 StructureSize => 57;

        /// <summary>
        /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client
        /// </summary>
        public Byte SecurityFlags => 0;
        /// <summary>
        /// Reserved (2 bytes): The client MUST set this to 0, and the server SHOULD<8> ignore it on receipt.
        /// </summary>
        public RequestedOplockLevels RequestedOplockLevel;
        /// <summary>
        /// Capabilities (4 bytes): If the client implements the SMB 3.x dialect family, the Capabilities field MUST be constructed using the following values. 
        /// Otherwise, this field MUST be set to 0.
        /// </summary>
        public ImpersonationLevelsRequest ImpersonationLevel;
        /// <summary>
        /// SmbCreateFlags (8 bytes): This field MUST NOT be used and MUST be reserved. The client SHOULD set this field to zero, and the server MUST ignore it on receipt.
        /// </summary>
        public Int64 SmbCreateFlags => 0;
        /// <summary>
        /// Reserved (8 bytes): This field MUST NOT be used and MUST be reserved. The client sets this to any value, and the server MUST ignore it on receipt.
        /// </summary>
        public Int64 Reserved => 0;
        /// <summary>
        /// </summary>
        public IAccess_Mask DesiredAccess;

        public Int32 FileAttributes;
        public ShareAccessRequest ShareAccess;
        public CreateDispositionRequest CreateDisposition;
        public CreateOptionsRequest CreateOptions;


        public Int16 NameOffset;
        public Int16 NameLength;
        public Int32 CreateContextsOffset;
        public Int32 CreateContextsLength;
        public ICreateContextBuffer Buffer;
    }
}
