using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    internal struct LUID_ATTR_DATA
    {
        /// <summary>
        /// Luid (8 bytes): Locally unique identifier, as specified in [MS-DTYP] section 2.3.7.
        /// </summary>
        public GUID Luid;

        ///TODO
        /// <summary>
        /// Attr (4 bytes): LUID attributes as specified in [MS-LSAD] section 2.2.5.4.
        /// </summary>
        public UInt32 Attr;
    }
}
