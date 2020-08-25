using System;
using System.Dynamic;

namespace Smb.Core
{

    /// <summary>
    /// Dialects (variable): An array of one or more 16-bit integers specifying the supported dialect revision numbers. The array MUST contain at least one of the following values.
    /// </summary>
    [Flags]
    internal enum Dialects : UInt16
    {
        /// <summary>
        /// SMB 2.0.2 dialect revision number.
        /// </summary>
        SMB_2_0_2 = 0x0202,
        /// <summary>
        /// SMB 2.1 dialect revision number.<9>
        /// </summary>
        SMB_2_1_0 = 0x0210,
        /// <summary>
        /// SMB 3.0 dialect revision number. <10>
        /// </summary>
        SMB_3_0_0 = 0x0300,
        /// <summary>
        /// SMB 3.0.2 dialect revision number. <11>
        /// </summary>
        SMB_3_0_2 = 0x0302,
        /// <summary>
        /// SMB 3.1.1 dialect revision number.<12>
        /// </summary>
        SMB_3_1_1 = 0x0311,
    }


    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    [Flags]
    internal enum NegotiateSecurityModes : UInt16
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
    internal enum NegotiateCapabilities : UInt32
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






    /// <summary>
    /// Dialects (variable): An array of one or more 16-bit integers specifying the supported dialect revision numbers. The array MUST contain at least one of the following values.
    /// </summary>
    [Flags]
    internal enum DialectRevision : UInt16
    {
        /// <summary>
        /// SMB 2.0.2 dialect revision number.
        /// </summary>
        SMB_2_0_2 = 0x0202,
        /// <summary>
        /// SMB 2.1 dialect revision number.<15>
        /// </summary>
        SMB_2_1_0 = 0x0210,
        /// <summary>
        /// SMB 3.0 dialect revision number.<16>
        /// </summary>
        SMB_3_0_0 = 0x0300,
        /// <summary>
        /// SMB 3.0.2 dialect revision number.<17>
        /// </summary>
        SMB_3_0_2 = 0x0302,
        /// <summary>
        /// SMB 3.1.1 dialect revision number. <18>
        /// </summary>
        SMB_3_1_1 = 0x0311,
        /// <summary>
        /// SMB2 wildcard revision number; indicates that the server implements SMB 2.1 or future dialect revisions and expects the client to send a subsequent SMB2 Negotiate request to negotiate the actual SMB 2 Protocol revision to be used. The wildcard revision number is sent only in response to a multi-protocol negotiate request with the "SMB 2.???" dialect string.<19>
        /// </summary>
        SMB_2_F_F = 0x02FF,
    }

}
