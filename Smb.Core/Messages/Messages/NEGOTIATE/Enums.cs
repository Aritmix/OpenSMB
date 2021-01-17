using System;
using System.Dynamic;

namespace Smb.Core.Messages
{
    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    [Flags]
    public enum NegotiateSecurityModes : UInt16
    {
        /// <summary>
        /// When set, indicates that security signatures are enabled on the client. The client MUST set this bit if the SMB2_NEGOTIATE_SIGNING_REQUIRED bit is not set, and MUST NOT set this bit if the SMB2_NEGOTIATE_SIGNING_REQUIRED bit is set. The server MUST ignore this bit.
        /// </summary>
        SMB2_NEGOTIATE_SIGNING_ENABLED = 0x0001,
        /// <summary>
        /// When set, indicates that security signatures are required by the client.
        /// </summary>
        SMB2_NEGOTIATE_SIGNING_REQUIRED = 0x0002,
    }

    /// <summary>
    /// Capabilities (4 bytes): If the client implements the SMB 3.x dialect family
    /// </summary>
    [Flags]
    public enum NegotiateCapabilities : UInt32
    {
        /// <summary>
        /// When set, indicates that the client supports the Distributed File System (DFS).
        /// </summary>
        SMB2_GLOBAL_CAP_DFS = 0x00000001,
        /// <summary>
        /// When set, indicates that the client supports leasing.
        /// </summary>
        SMB2_GLOBAL_CAP_LEASING = 0x00000002,
        /// <summary>
        /// When set, indicates that the client supports multi-credit operations.
        /// </summary>
        SMB2_GLOBAL_CAP_LARGE_MTU = 0x00000004,
        /// <summary>
        /// When set, indicates that the client supports establishing multiple channels for a single session.
        /// </summary>
        SMB2_GLOBAL_CAP_MULTI_CHANNEL = 0x00000008,
        /// <summary>
        /// When set, indicates that the client supports persistent handles.
        /// </summary>
        SMB2_GLOBAL_CAP_PERSISTENT_HANDLES = 0x00000010,
        /// <summary>
        /// When set, indicates that the client supports directory leasing.
        /// </summary>
        SMB2_GLOBAL_CAP_DIRECTORY_LEASING = 0x00000020,
        /// <summary>
        /// When set, indicates that the client supports encryption.
        /// </summary>
        SMB2_GLOBAL_CAP_ENCRYPTION = 0x00000040,
    }

    

}
