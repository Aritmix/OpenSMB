using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    /// <summary>
    /// SecurityMode (2 bytes): The security mode field specifies whether SMB signing is enabled or required at the client. This field MUST be constructed using the following values.
    /// </summary>
    internal enum HashAlgorithms : UInt16
    {
        /// <summary>
        /// SHA-512 as specified in [FIPS180-4] 
        /// </summary>
        SHA_512 = 0x0001,
    }


    /// <summary>
    /// The SMB2_PREAUTH_INTEGRITY_CAPABILITIES context is specified in an SMB2 NEGOTIATE request by the client to indicate which preauthentication integrity hash algorithms the client supports and to optionally supply a preauthentication integrity hash salt value. The format of the data in the Data field of this SMB2_NEGOTIATE_CONTEXT is as follows.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal struct PREAUTH_INTEGRITY_CAPABILITIES : ICapability
    {
        /// <summary>
        /// HashAlgorithmCount (2 bytes): The number of hash algorithms in the HashAlgorithms array. This value MUST be greater than zero.
        /// </summary>
        public UInt16 HashAlgorithmCount => (UInt16)HashAlgorithms?.Length;
        /// <summary>
        /// SaltLength (2 bytes): The size, in bytes, of the Salt field.
        /// </summary>
        public UInt16 SaltLength => (UInt16)Salt?.Length;
        /// <summary>
        /// HashAlgorithms (variable): An array of HashAlgorithmCount 16-bit integer IDs specifying the supported preauthentication integrity hash functions. The following IDs are defined.
        /// </summary>
        public HashAlgorithms[] HashAlgorithms;
        /// <summary>
        /// Data (variable): A variable-length field that contains the negotiate context specified by the ContextType field.
        /// </summary>
        public Byte[] Salt;
    }
}
