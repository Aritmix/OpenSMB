using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{

    /// <summary>
    /// CompressionAlgorithms (variable): An array of 16-bit integer IDs specifying the supported compression algorithms. These IDs MUST be in order of preference from most to least. The following IDs are defined.
    /// </summary>
    public enum CompressionAlgorithms : UInt16
    {
        /// <summary>
        /// No compression
        /// </summary>
        NONE = 0x0000,
        /// <summary>
        /// LZNT1 compression algorithm
        /// </summary>
        LZNT1 = 0x0001,
        /// <summary>
        /// LZ77 compression algorithm 
        /// </summary>
        LZ77 = 0x0002,
        /// <summary>
        /// LZ77+Huffman compression algorithm 
        /// </summary>
        LZ77_N_Huffman = 0x0003,
    }

    /// <summary>
    /// The SMB2_COMPRESSION_CAPABILITIES context is specified in an SMB2 NEGOTIATE request by the client to indicate which compression algorithms the client supports. The format of the data in the Data field of this SMB2_NEGOTIATE_CONTEXT is as follows.
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal struct COMPRESSION_CAPABILITIES : ICapability
    {
        /// <summary>
        /// CompressionAlgorithmCount (2 bytes): The number of elements in CompressionAlgorithms array. 
        /// </summary>
        public UInt16 CompressionAlgorithmCount => (UInt16)CompressionAlgorithms?.Length;

        /// <summary>
        /// Padding (2 bytes): The sender MUST set this to 0, and the receiver MUST ignore it on receipt.
        /// </summary>
        public UInt16 Padding => 0;

        /// <summary>
        /// Reserved (4 bytes): This field MUST NOT be used and MUST be reserved. The sender MUST set this to 0, and the receiver MUST ignore it on receipt.
        /// </summary>
        public UInt32 Reserved => 0;

        /// <summary>
        /// CompressionAlgorithms (variable): An array of 16-bit integer IDs specifying the supported compression algorithms. These IDs MUST be in order of preference from most to least. 
        /// </summary>
        public CompressionAlgorithms[] CompressionAlgorithms;
    }
}
