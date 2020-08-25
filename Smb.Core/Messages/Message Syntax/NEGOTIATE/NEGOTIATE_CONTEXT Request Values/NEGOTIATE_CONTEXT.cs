using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    internal enum ContextType : UInt16
    {
        /// <summary>
        /// The Data field contains a list of preauthentication integrity hash functions as well as an optional salt value, as specified in section 2.2.3.1.1.
        /// </summary>
        SMB2_PREAUTH_INTEGRITY_CAPABILITIES = 0x0001,
        /// <summary>
        /// The Data field contains a list of encryption algorithms, as specified in section 2.2.3.1.2.
        /// </summary>
        SMB2_ENCRYPTION_CAPABILITIES = 0x0002,
        /// <summary>
        /// The Data field contains a list of compression algorithms, as specified in section 2.2.3.1.3<13>. 
        /// </summary>
        SMB2_COMPRESSION_CAPABILITIES = 0x0003,
        /// <summary>
        /// The Data field contains the server name to which the client connects<14>.
        /// </summary>
        SMB2_NETNAME_NEGOTIATE_CONTEXT_ID = 0x0005,

    }


    /// <summary>
    /// The SMB2_NEGOTIATE_CONTEXT structure is used by the SMB2 NEGOTIATE Request and the SMB2 NEGOTIATE Response to encode additional properties.
    /// The server MUST support receiving negotiate contexts in any order.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class NEGOTIATE_CONTEXT
    {
        /// <summary>
        /// ContextType (2 bytes): Specifies the type of context in the Data field. This field MUST be one of the following values:
        /// </summary>
        public ContextType ContextType;
        /// <summary>
        /// DataLength (2 bytes): The length, in bytes, of the Data field.
        /// </summary>
        public UInt16 DataLength => (UInt16)Data?.Length;
        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. This value MUST be set to 0 by the client, and MUST be ignored by the server.
        /// </summary>
        public UInt32 Reserved => 0;
        /// <summary>
        /// Data (variable): A variable-length field that contains the negotiate context specified by the ContextType field.
        /// </summary>
        public Byte[] Data;
    }
}
