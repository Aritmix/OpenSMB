using Smb.Core.Messages;
using System;

namespace Smb.Core.Models
{
    /// <summary>
    /// </summary>
    internal struct SID_ATTR_DATA
    {
        /// <summary>
        /// SidData (variable): SID, as specified in [MS-DTYP] section 2.4.2.2, information in BLOB_DATA format as specified in section 2.2.9.2.1.1. BlobSize MUST be set to the size of SID and BlobData MUST be set to the SID value.
        /// </summary>
        public Byte[] SidData;
        /// <summary>
        /// BlobData (variable): Blob data.
        /// </summary>
        public TreeConnectContextType Attr;
    }
}
