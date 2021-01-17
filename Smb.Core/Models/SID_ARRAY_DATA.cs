using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Models
{
    /// <summary>
    /// </summary>
    internal struct SID_ARRAY_DATA
    {
        /// <summary>
        /// SidAttrCount (2 bytes): Number of SID_ATTR_DATA elements in SidAttrList array.
        /// </summary>
        public UInt16 SidAttrCount => (UInt16)SidAttrList?.Length;
        /// <summary>
        /// SidAttrList (variable): An array with SidAttrCount number of SID_ATTR_DATA elements as specified in section 2.2.9.2.1.2.
        /// </summary>
        public SID_ATTR_DATA[] SidAttrList;
    }
}
