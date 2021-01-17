using System;

namespace Smb.Core.Models
{
    /// <summary>
    /// The SMB2 FILEID is used to represent an open to a file.
    /// </summary>
    internal struct FILEID
    {
        /// <summary>
        /// Persistent (8 bytes): A file handle that remains persistent when an open is reconnected after being lost on a disconnect, as specified in section 3.3.5.9.7. The server MUST return this file handle as part of an SMB2 CREATE Response (section 2.2.14). 
        /// </summary>
        public UInt64 Persistent;
        /// <summary>
        /// Volatile (8 bytes): A file handle that can be changed when an open is reconnected after being lost on a disconnect, as specified in section 3.3.5.9.7. The server MUST return this file handle as part of an SMB2 CREATE Response (section 2.2.14). This value MUST NOT change unless a reconnection is performed. 
        /// This value MUST be unique for all volatile handles within the scope of a session.
        /// </summary>
        public UInt64 Volatile;
    }
}
