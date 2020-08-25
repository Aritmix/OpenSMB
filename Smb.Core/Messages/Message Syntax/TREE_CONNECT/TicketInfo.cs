using System;
using System.Dynamic;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 FILEID is used to represent an open to a file.
    /// </summary>

    internal struct TicketInfo
    {
        /// <summary>
        /// The user information is stored in SID_ATTR_DATA format as specified in section 2.2.9.2.1.2
        /// </summary>
        public SID_ATTR_DATA User;
        /// <summary>
        /// 
        /// </summary>
        public String UserName;
        /// <summary>
        /// 
        /// </summary>
        public String Domain;
        /// <summary>
        /// 
        /// </summary>
        public SID_ARRAY_DATA Groups;
        /// <summary>
        /// 
        /// </summary>
        public SID_ARRAY_DATA RestrictedGroups;
        /// <summary>
        /// 
        /// </summary>
        public PRIVILEGE_ARRAY_DATA Privileges;
        /// <summary>
        /// 
        /// </summary>
        public SID_ARRAY_DATA PrimaryGroup;
        /// <summary>
        /// 
        /// </summary>
        public BLOB_DATA<SID> Owner;

        ///TODO
        /// <summary>
        /// 
        /// </summary>
        public BLOB_DATA DefaultDacl;
        /// <summary>
        /// 
        /// </summary>
        public SID_ARRAY_DATA DeviceGroups;
        /// <summary>
        /// 
        /// </summary>
        public BLOB_DATA<CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1[]> UserClaims;
    }
}
