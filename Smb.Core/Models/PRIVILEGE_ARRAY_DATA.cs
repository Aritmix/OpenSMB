using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    internal struct PRIVILEGE_ARRAY_DATA
    {
        /// <summary>
        /// PrivilegeCount (2 bytes): Number of PRIVILEGE_DATA elements in PrivilegeList array.
        /// </summary>
        public UInt16 PrivilegeCount => (UInt16)PrivilegeList?.Length;
        /// <summary>
        /// BlobData (variable): Blob data.
        /// </summary>
        public PRIVILEGE_DATA[] PrivilegeList;
    }
}
