using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    /// <summary>
    /// The SMB2_REMOTED_IDENTITY_TREE_CONNECT context is specified in SMB2_TREE_CONNECT_CONTEXT structure when the ContextType is set to SMB2_REMOTED_IDENTITY_TREE_CONNECT_CONTEXT_ID. The format of the data in the Data field of this SMB2_TREE_CONNECT_CONTEXT is as follows:
    /// </summary>
    internal struct REMOTED_IDENTITY_TREE_CONNECT_Context
    {
        /// <summary>
        /// TicketType (2 bytes): A 16-bit integer specifying the type of ticket requested. The value in this field MUST be set to 0x0001.
        /// </summary>
        public UInt16 TicketType => 0x0001;
        /// <summary>
        /// TicketSize (2 bytes): A 16-bit integer specifying the total size of this structure.
        /// </summary>
        public UInt16 TicketSize => (UInt16)Marshal.SizeOf<REMOTED_IDENTITY_TREE_CONNECT_Context>(this);
        /// <summary>
        /// User (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the user information in the TicketInfo buffer. The user information is stored in SID_ATTR_DATA format as specified in section 2.2.9.2.1.2.
        /// </summary>
        public UInt16 User {get; set;}
        /// <summary>
        /// UserName (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the null-terminated Unicode string containing the username in the TicketInfo field.
        /// </summary>
        public UInt16 UserName;
        /// <summary>
        /// Domain (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the null-terminated Unicode string containing the domain name in the TicketInfo field.
        /// </summary>
        public UInt16 Domain;
        /// <summary>
        /// Groups (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the groups in the TicketInfo buffer. The information is stored in SID_ARRAY_DATA format as specified in section 2.2.9.2.1.3.
        /// </summary>
        public UInt16 Groups;
        /// <summary>
        /// RestrictedGroups (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the restricted groups in the TicketInfo field. The information is stored in SID_ARRAY_DATA format as specified in section 2.2.9.2.1.3.
        /// </summary>
        public UInt16 RestrictedGroups;
        /// <summary>
        /// Privileges (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the privileges in the TicketInfo field. The information is stored in PRIVILEGE_ARRAY_DATA format as specified in section 2.2.9.2.1.6.
        /// </summary>
        public UInt16 Privileges;
        /// <summary>
        /// PrimaryGroup (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the primary group in the TicketInfo field. The information is stored in SID_ARRAY_DATA format as specified in section 2.2.9.2.1.3.
        /// </summary>
        public UInt16 PrimaryGroup;
        /// <summary>
        /// Owner (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the owner in the TicketInfo field. The information is stored in BLOB_DATA format as specified in section 2.2.9.2.1.1, where BlobData contains the SID, as specified in [MS-DTYP] section 2.4.2.2, representing the owner, and BlobSize contains the size of SID.
        /// </summary>
        public UInt16 Owner;
        /// <summary>
        /// DefaultDacl (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the DACL, as specified in [MS-DTYP] section 2.5.2, in the TicketInfo field. Information about the DACL is stored in BLOB_DATA format as specified in section 2.2.9.2.1.1, where BlobSize contains the size of the ACL structure, as specified in [MS-DTYP] section 2.4.5, and BlobData contains the DACL data.
        /// </summary>
        public UInt16 DefaultDacl;
        /// <summary>
        /// DeviceGroups (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the information about the device groups in the TicketInfo field. The information is stored in SID_ARRAY_DATA format as specified in section 2.2.9.2.1.3.
        /// </summary>
        public UInt16 DeviceGroups;
        /// <summary>
        /// UserClaims (2 bytes): A 16-bit integer specifying the offset, in bytes, from the beginning of this structure to the user claims data in the TicketInfo field. Information about user claims is stored in BLOB_DATA format as specified in section 2.2.9.2.1.1, where BlobData contains an array of CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 structures, as specified in [MS-DTYP] section 2.4.10.1, representing the claims issued to the user, and BlobSize contains the size of the user claims data.
        /// </summary>
        public UInt16 UserClaims;
        /// <summary>
        /// TicketInfo (variable): A variable-length buffer containing the remoted identity tree connect context data, including the information about all the previously defined fields in this structure.
        /// </summary>
        public TicketInfo[] TicketInfo;
    }
}
