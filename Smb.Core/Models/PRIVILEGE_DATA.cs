using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    internal struct PRIVILEGE_DATA 
    {
        /// <summary>
        /// BlobSize (2 bytes): Size of the data, in bytes, in BlobData.
        /// </summary>
        public UInt16 BlobSize => (UInt16)Marshal.SizeOf<LUID_ATTR_DATA>();
        /// <summary>
        /// BlobData (variable): Blob data.
        /// </summary>
        public LUID_ATTR_DATA BlobData;
    }
}
