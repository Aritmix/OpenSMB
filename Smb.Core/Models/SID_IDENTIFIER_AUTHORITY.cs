using System;
using System.Dynamic;
using static Smb.Core.Messages.MarshallingAttributes;

namespace Smb.Core.Models
{
    /// <summary>
    /// This is a packet representation of the SID type (as specified in section 2.4.2) for use by block protocols. Multiple-byte fields are transmitted on the wire with an endianness specified by the protocol in question.
    /// </summary>

    internal struct SID_IDENTIFIER_AUTHORITY
    {
        /// <summary>
        /// Value (6 bytes): An array of six 8-bit unsigned integers that specify the top-level authority of a SID, RPC_SID, and LSAPR_SID_INFORMATION.
        /// </summary>
        [StaticSize(6, StaticSizeMode.Elements)]
        public Byte[] Value;
    }

    public static class SID_IDENTIFIER_AUTHORITIES
    {
        /// <summary>
        /// Specifies the NULL SID authority. It defines only the NULL well-known-SID: S-1-0-0.
        /// </summary>
        public static readonly Byte[] NULL_SID_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        /// <summary>
        /// Specifies the World SID authority. It only defines the Everyone well-known-SID: S-1-1-0.
        /// </summary>
        public static readonly Byte[] WORLD_SID_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        /// <summary>
        /// Specifies the Local SID authority. It defines only the Local well-known-SID: S-1-2-0.
        /// </summary>
        public static readonly Byte[] LOCAL_SID_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x02 };
        /// <summary>
        /// Specifies the Creator SID authority. It defines the Creator Owner, Creator Group, and Creator Owner Server well-known-SIDs: S-1-3-0, S-1-3-1, and S-1-3-2. These SIDs are used as placeholders in an access control list (ACL) and are replaced by the user, group, and machine SIDs of the security principal.
        /// </summary>
        public static readonly Byte[] CREATOR_SID_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 };
        /// <summary>
        /// Not used.
        /// </summary>
        public static readonly Byte[] NON_UNIQUE_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x04 };
        /// <summary>
        /// Specifies the Windows NT operating system security subsystem SID authority. It defines all other SIDs in the forest.
        /// </summary>
        public static readonly Byte[] SECURITY_NT_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x05 };
        /// <summary>
        /// Specifies the application package authority. It defines application capability SIDs.
        /// </summary>
        public static readonly Byte[] SECURITY_APP_PACKAGE_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F };
        /// <summary>
        /// Specifies the Mandatory label authority. It defines the integrity level SIDs.
        /// </summary>
        public static readonly Byte[] SECURITY_MANDATORY_LABEL_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x10 };
        /// <summary>
        /// Specifies the Scoped Policy Authority. It defines all other scoped policy SIDs in the forest.<5>
        /// </summary>
        public static readonly Byte[] SECURITY_SCOPED_POLICY_ID_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x11 };
        /// <summary>
        /// Specifies the authentication authority asserting the client’s identity. It defines only the following well-known SIDs: S-1-18-1, and S-1-18-2.<6>
        /// </summary>
        public static readonly Byte[] SECURITY_AUTHENTICATION_AUTHORITY = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x12 };
    }

}
