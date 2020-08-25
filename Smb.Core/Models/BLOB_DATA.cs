using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    internal struct BLOB_DATA
    {
        /// <summary>
        /// BlobSize (2 bytes): Size of the data, in bytes, in BlobData.
        /// </summary>
        public UInt16 BlobSize => (UInt16)BlobData?.Length;
        /// <summary>
        /// BlobData (variable): Blob data.
        /// </summary>
        public Byte[] BlobData;
    }

    /// <summary>
    /// </summary>
    internal struct BLOB_DATA<T>
    {
        /// <summary>
        /// BlobSize (2 bytes): Size of the data, in bytes, in BlobData.
        /// </summary>
        public UInt16 BlobSize => (UInt16)BlobData?.Length;
        /// <summary>
        /// BlobData (variable): Blob data.
        /// </summary>
        public T[] BlobData;
    }
}
