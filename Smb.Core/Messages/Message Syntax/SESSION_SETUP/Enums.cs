using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// Dialects (variable): An array of one or more 16-bit integers specifying the supported dialect revision numbers. The array MUST contain at least one of the following values.
    /// </summary>
    [Flags]
    internal enum SessionSetupFlags : Byte
    {
        /// <summary>
        /// When set, indicates that the request is to bind an existing session to a new connection.
        /// </summary>
        SMB2_SESSION_FLAG_BINDING = 0x01,
    }

    /// <summary>
    /// SessionFlags (2 bytes): A flags field that indicates additional information about the session. This field MUST contain either 0 or one of the following values:
    /// </summary>
    [Flags]
    internal enum SessionSetupResponseFlags : UInt16
    {
        /// <summary>
        /// If set, the client has been authenticated as a guest user.
        /// </summary>
        SMB2_SESSION_FLAG_IS_GUEST = 0x0001,
        /// <summary>
        /// If set, the client has been authenticated as an anonymous user.
        /// </summary>
        SMB2_SESSION_FLAG_IS_NULL = 0x0002,
        /// <summary>
        /// If set, the server requires encryption of messages on this session, per the conditions specified in section 3.3.5.2.9. This flag is only valid for the SMB 3.x dialect family.
        /// </summary>
        SMB2_SESSION_FLAG_ENCRYPT_DATA = 0x0004,
    }

    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    [Flags]
    internal enum SessionSetupSecurityModes : Byte
    {
        /// <summary>
        /// When set, indicates that security signatures are enabled on the client. The client MUST set this bit if the SMB2_NEGOTIATE_SIGNING_REQUIRED bit is not set, and MUST NOT set this bit if the SMB2_NEGOTIATE_SIGNING_REQUIRED bit is set. The server MUST ignore this bit.
        /// </summary>
        SMB2_NEGOTIATE_SIGNING_ENABLED = 0x01,
        /// <summary>
        /// When set, indicates that security signatures are required by the client.
        /// </summary>
        SMB2_NEGOTIATE_SIGNING_REQUIRED = 0x02,
    }

    /// <summary>
    /// Capabilities (4 bytes): If the client implements the SMB 3.x dialect family
    /// </summary>
    [Flags]
    internal enum SessionSetupCapabilities : UInt32
    {
        /// <summary>
        /// When set, indicates that the client supports the Distributed File System (DFS).
        /// </summary>
        SMB2_GLOBAL_CAP_DFS = 0x00000001,
        /// <summary>
        /// SHOULD be set to zero, and server MUST ignore.
        /// </summary>
        SMB2_GLOBAL_CAP_UNUSED1 = 0x00000002,
        /// <summary>
        /// SHOULD be set to zero, and server MUST ignore.
        /// </summary>
        SMB2_GLOBAL_CAP_UNUSED2 = 0x00000004,
        /// <summary>
        /// SHOULD be set to zero, and server MUST ignore.
        /// </summary>
        SMB2_GLOBAL_CAP_UNUSED3 = 0x00000008,
    }

}
