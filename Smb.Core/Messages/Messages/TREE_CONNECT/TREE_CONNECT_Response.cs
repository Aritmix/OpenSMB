using System;
using System.Dynamic;

namespace Smb.Core.Messages
{
    /// <summary>
    /// ShareType (1 byte): The type of share being accessed. This field MUST contain one of the following values.
    /// </summary>
    internal enum ShareType : Byte
    {
        /// <summary>
        /// Physical disk share.
        /// </summary>
        SMB2_SHARE_TYPE_DISK = 0x01,
        /// <summary>
        /// Named pipe share.
        /// </summary>
        SMB2_SHARE_TYPE_PIPE = 0x02,
        /// <summary>
        /// Printer share.
        /// </summary>
        SMB2_SHARE_TYPE_PRINT = 0x03,
    }

    /// <summary>
    /// ShareFlags (4 bytes): This field contains properties for this share.
    /// </summary>
    [Flags]
    internal enum ShareFlags : UInt32
    {
        /// <summary>
        /// The client can cache files that are explicitly selected by the user for offline use.
        /// </summary>
        SMB2_SHAREFLAG_MANUAL_CACHING = 0x00000000,
        /// <summary>
        /// The client can automatically cache files that are used by the user for offline access.
        /// </summary>
        SMB2_SHAREFLAG_AUTO_CACHING = 0x00000010,
        /// <summary>
        /// The client can automatically cache files that are used by the user for offline access and can use those files in an offline mode even if the share is available.
        /// </summary>
        SMB2_SHAREFLAG_VDO_CACHING = 0x00000020,
        /// <summary>
        /// Offline caching MUST NOT occur.
        /// </summary>
        SMB2_SHAREFLAG_NO_CACHING = 0x00000030,
        /// <summary>
        /// The specified share is present in a Distributed File System (DFS) tree structure. The server SHOULD set the SMB2_SHAREFLAG_DFS bit in the ShareFlags field if the per-share property Share.IsDfs is TRUE.
        /// </summary>
        SMB2_SHAREFLAG_DFS = 0x00000001,
        /// <summary>
        /// The specified share is present in a DFS tree structure. The server SHOULD set the SMB2_SHAREFLAG_DFS_ROOT bit in the ShareFlags field if the per-share property Share.IsDfs is TRUE.
        /// </summary>
        SMB2_SHAREFLAG_DFS_ROOT = 0x00000002,
        /// <summary>
        /// The specified share disallows exclusive file opens that deny reads to an open file.
        /// </summary>
        SMB2_SHAREFLAG_RESTRICT_EXCLUSIVE_OPENS = 0x00000100,
        /// <summary>
        /// The specified share disallows clients from opening files on the share in an exclusive mode that prevents the file from being deleted until the client closes the file. 
        /// </summary>
        SMB2_SHAREFLAG_FORCE_SHARED_DELETE = 0x00000200,
        /// <summary>
        /// The client MUST ignore this flag.
        /// </summary>
        SMB2_SHAREFLAG_ALLOW_NAMESPACE_CACHING = 0x00000400,
        /// <summary>
        /// The server will filter directory entries based on the access permissions of the client.
        /// </summary>
        SMB2_SHAREFLAG_ACCESS_BASED_DIRECTORY_ENUM = 0x00000800,
        /// <summary>
        /// The server will not issue exclusive caching rights on this share.<27>
        /// </summary>
        SMB2_SHAREFLAG_FORCE_LEVELII_OPLOCK = 0x00001000,
        /// <summary>
        /// The share supports hash generation for branch cache retrieval of data. For more information, see section 2.2.31.2. This flag is not valid for the SMB 2.0.2 dialect.
        /// </summary>
        SMB2_SHAREFLAG_ENABLE_HASH_V1 = 0x00002000,
        /// <summary>
        /// The share supports v2 hash generation for branch cache retrieval of data. For more information, see section 2.2.31.2. This flag is not valid for the SMB 2.0.2 and SMB 2.1 dialects.
        /// </summary>
        SMB2_SHAREFLAG_ENABLE_HASH_V2 = 0x00004000,
        /// <summary>
        /// The server requires encryption of remote file access messages on this share, per the conditions specified in section 3.3.5.2.11. This flag is only valid for the SMB 3.x dialect family.
        /// </summary>
        SMB2_SHAREFLAG_ENCRYPT_DATA = 0x00008000,
        /// <summary>
        /// The share supports identity remoting. The client can request remoted identity access for the share via the SMB2_REMOTED_IDENTITY_TREE_CONNECT context as specified in section 2.2.9.2.1.
        /// </summary>
        SMB2_SHAREFLAG_IDENTITY_REMOTING = 0x00040000
    }


    /// <summary>
    /// The SMB2 TREE_CONNECT Response packet is sent by the server when an SMB2 TREE_CONNECT request is processed successfully by the server. This response is composed of an SMB2 Packet Header (section 2.2.1) that is followed by this response structure.
    /// </summary>
    internal class TREE_CONNECT_Response
    {
        /// <summary>
        /// StructureSize (2 bytes): The server MUST set this field to 16, indicating the size of the response structure, not including the header.
        /// </summary>
        public UInt16 StructureSize => 16;
        /// <summary>
        /// ShareType (1 byte): The type of share being accessed. This field MUST contain one of the following values.
        /// </summary>
        public ShareType ShareType;
        /// <summary>
        /// Reserved (1 byte): This field MUST NOT be used and MUST be reserved. The server MUST set this to 0, and the client MUST ignore it on receipt.
        /// </summary>
        public Byte Reserved => 0;
        /// <summary>
        /// ShareFlags (4 bytes): This field contains properties for this share.
        /// This field MUST contain one of the following offline caching properties: SMB2_SHAREFLAG_MANUAL_CACHING, SMB2_SHAREFLAG_AUTO_CACHING, SMB2_SHAREFLAG_VDO_CACHING and SMB2_SHAREFLAG_NO_CACHING.
        /// For more information about offline caching, see[OFFLINE].
        /// This field MUST contain zero or more of the following values: SMB2_SHAREFLAG_DFS, SMB2_SHAREFLAG_DFS_ROOT, SMB2_SHAREFLAG_RESTRICT_EXCLUSIVE_OPENS, SMB2_SHAREFLAG_FORCE_SHARED_DELETE, SMB2_SHAREFLAG_ALLOW_NAMESPACE_CACHING, SMB2_SHAREFLAG_ACCESS_BASED_DIRECTORY_ENUM, SMB2_SHAREFLAG_FORCE_LEVELII_OPLOCK and SMB2_SHAREFLAG_ENABLE_HASH.
        /// </summary>
        public ShareFlags ShareFlags;
        /// <summary>
        /// Capabilities (4 bytes): Indicates various capabilities for this share. This field MUST be constructed using the following values.
        /// </summary>
        public TreeConnectCapabilities Capabilities;
        /// <summary>
        /// MaximalAccess (4 bytes): Contains the maximal access for the user that establishes the tree connect on the share based on the share's permissions. This value takes the form as specified in section 2.2.13.1.
        /// </summary>
        public UInt32 MaximalAccess;
    }
}
