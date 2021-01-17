using Smb.Core.Share;
using System;

namespace Smb.Core.Shared
{
    public class SMBServerShare
    {
        /// <summary>
        /// A name for the shared resource on this server
        /// </summary>
        public String Name;

        /// <summary>
        /// The NetBIOS, fully qualified domain name (FQDN), or textual IPv4 or  IPv6 address that the share is associated with.
        /// For more information, see[MS - SRVS] section 3.1.1.7. 
        /// </summary>
        public String ServerName;

        /// <summary>
        /// The optional support bits for the share; the format is specified in section 2.2.7.
        /// </summary>
        public int OptionalSupport;

        /// <summary>
        /// The type of share (that is, disk, printer, named pipe).
        /// </summary>
        public ShareTypes Type;

        public String LocalPath;

        public String ConnectionSecurity;

        public String FileSecurity;

        public CSCFlags CSCFlags;

        public bool IsDfs;

        public bool DoAccessBasedDirectoryEnumeration;

        public bool AllowNamespaceCaching;

        public bool ForceSharedDelete;

        public bool RestrictExclusiveOpens;

        public uint MaxUsers;

        public uint CurrentUsers;

        public bool ForceLevel2Oplock;

        public bool HashEnabled;

        public bool IsCA;

    }
}
