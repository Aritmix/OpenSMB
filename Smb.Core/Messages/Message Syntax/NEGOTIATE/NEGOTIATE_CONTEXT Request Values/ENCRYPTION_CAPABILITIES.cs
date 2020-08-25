using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    internal enum Ciphers : UInt16
    {
        /// <summary>
        /// AES-128-CCM
        /// </summary>
        AES_128_CCM = 0x0001,
        /// <summary>
        /// AES-128-GCM
        /// </summary>
        AES_128_GCM = 0x0002,
    }


    /// <summary>
    /// The SMB2_ENCRYPTION_CAPABILITIES context is specified in an SMB2 NEGOTIATE request by the client to indicate which encryption algorithms the client supports. The format of the data in the Data field of this SMB2_NEGOTIATE_CONTEXT is as follows.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal struct ENCRYPTION_CAPABILITIES : ICapability
    {
        /// <summary>
        /// CipherCount (2 bytes): The number of ciphers in the Ciphers array. This value MUST be greater than zero.
        /// </summary>
        public UInt16 CipherCount => (UInt16)Ciphers?.Length;
        /// <summary>
        /// HashAlgorithms (variable): An array of HashAlgorithmCount 16-bit integer IDs specifying the supported preauthentication integrity hash functions. The following IDs are defined.
        /// </summary>
        public Ciphers[] Ciphers;
    }
}
