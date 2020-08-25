using System;
using System.Dynamic;

namespace Smb.Core
{

    /// <summary>
    /// Flags/Reserved (2 bytes): This field is interpreted in different ways depending on the SMB2 dialect.
    /// In the SMB 3.1.1 dialect, this field is interpreted as the Flags field, which indicates how to process the operation.
    /// </summary>
    [Flags]
    internal enum TreeConnectFlags : UInt16
    {
        /// <summary>
        /// When set, indicates that the client has previously connected to the specified cluster share using the SMB dialect of the connection on which the request is received.
        /// </summary>
        SMB2_TREE_CONNECT_FLAG_CLUSTER_RECONNECT = 0x0001,
        /// <summary>
        /// When set, indicates that the client can handle synchronous share redirects via a Share Redirect error context response as specified in section 2.2.2.2.2.
        /// </summary>
        SMB2_TREE_CONNECT_FLAG_REDIRECT_TO_OWNER = 0x0002,
        /// <summary>
        /// When set, indicates that a tree connect request extension, as specified in section 2.2.9.1, is present, starting at the Buffer field of this tree connect request. 
        /// </summary>
        SMB2_TREE_CONNECT_FLAG_EXTENSION_PRESENT = 0x0004,
    }

    /// <summary>
    /// ContextType(2 bytes) : Specifies the type of context in the Data field.This field MUST be one of the following values:    
    /// </summary>
    [Flags]
    internal enum TreeConnectContextType : UInt16
    {
        /// <summary>
        /// This value is reserved.
        /// </summary>
        SMB2_RESERVED_TREE_CONNECT_CONTEXT_ID = 0x0000,
        /// <summary>
        /// The Data field contains remoted identity tree connect context data as specified in section 2.2.9.2.1.
        /// </summary>
        SMB2_REMOTED_IDENTITY_TREE_CONNECT_CONTEXT_ID = 0x0001,
    }



    /// <summary>
    /// Attr (4 bytes): Specified attributes of the SID, containing the following values.
    /// </summary>
    [Flags]
    internal enum SidAttrs : UInt32
    {
        /// <summary>
        /// The SID is enabled for access checks. A SID without this attribute is ignored during an access check unless the SE_GROUP_USE_FOR_DENY_ONLY attribute is set.
        /// </summary>
        SE_GROUP_ENABLED = 0x00000004,
        /// <summary>
        /// The SID is enabled by default.
        /// </summary>
        SE_GROUP_ENABLED_BY_DEFAULT = 0x00000002,
        /// <summary>
        /// The SID is a mandatory integrity SID.
        /// </summary>
        SE_GROUP_INTEGRITY = 0x00000020,
        /// <summary>
        /// The SID is enabled for mandatory integrity checks.
        /// </summary>
        SE_GROUP_INTEGRITY_ENABLED = 0x00000040,
        /// <summary>
        /// The SID is a logon SID that identifies the logon session associated with an access token.
        /// </summary>
        SE_GROUP_LOGON_ID = 0xC0000000,
        /// <summary>
        /// The SID cannot have the SE_GROUP_ENABLED attribute cleared.
        /// </summary>
        SE_GROUP_MANDATORY = 0x00000001,
        /// <summary>
        /// The SID identifies a group account for which the user of the token is the owner of the group, or the SID can be assigned as the owner of the token or objects.
        /// </summary>
        SE_GROUP_OWNER = 0x00000008,
        /// <summary>
        /// The SID identifies a domain-local group.
        /// </summary>
        SE_GROUP_RESOURCE = 0x20000000,
        /// <summary>
        /// The SID is a deny-only SID in a restricted token. If this attribute is set, SE_GROUP_ENABLED is not set, and the SID cannot be reenabled.
        /// </summary>
        SE_GROUP_USE_FOR_DENY_ONLY = 0x00000010,
    }
    /// <summary>
    /// Capabilities (4 bytes): If the client implements the SMB 3.x dialect family
    /// </summary>
    [Flags]
    internal enum TreeConnectCapabilities : UInt32
    {
        /// <summary>
        /// The specified share is present in a DFS tree structure. The server MUST set the SMB2_SHARE_CAP_DFS bit in the Capabilities field if the per-share property Share.IsDfs is TRUE.
        /// </summary>
        SMB2_SHARE_CAP_DFS = 0x00000008,
        /// <summary>
        /// The specified share is continuously available. This flag is only valid for the SMB 3.x dialect family.
        /// </summary>
        SMB2_SHARE_CAP_CONTINUOUS_AVAILABILITY = 0x00000010,
        /// <summary>
        /// The specified share is present on a server configuration which facilitates faster recovery of durable handles. This flag is only valid for the SMB 3.x dialect family..
        /// </summary>
        SMB2_SHARE_CAP_SCALEOUT = 0x00000020,
        /// <summary>
        /// The specified share is present on a server configuration which provides monitoring of the availability of share through the Witness service specified in [MS-SWN]. This flag is only valid for the SMB 3.x dialect family.
        /// </summary>
        SMB2_SHARE_CAP_CLUSTER = 0x00000040,
        /// <summary>
        /// The specified share is present on a server configuration that allows dynamic changes in the ownership of the share. This flag is not valid for the SMB 2.0.2, 2.1, and 3.0 dialects.
        /// </summary>
        SMB2_SHARE_CAP_ASYMMETRIC = 0x00000080,
        /// <summary>
        /// The specified share is present on a server configuration that supports synchronous share level redirection via a Share Redirect error context response (section 2.2.2.2.2). This flag is not valid for SMB 2.0.2, 2.1, 3.0, and 3.0.2 dialects.
        /// </summary>
        SMB2_SHARE_CAP_REDIRECT_TO_OWNER = 0x00000100,
    }
}
