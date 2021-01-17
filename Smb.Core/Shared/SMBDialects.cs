using System;

namespace Smb.Core.Shared
{

    /// <summary>
    /// Dialects (variable): An array of one or more 16-bit integers specifying the supported dialect revision numbers. 
    /// The array MUST contain at least one of the following values.
    /// </summary>
    [Flags]
    public enum SMBDialects : UInt16
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
    /// Dialects (variable): An array of one or more 16-bit integers specifying the supported dialect revision numbers. 
    /// The array MUST contain at least one of the following values.
    /// </summary>
    [Flags]
    public enum DialectRevision : UInt16
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
