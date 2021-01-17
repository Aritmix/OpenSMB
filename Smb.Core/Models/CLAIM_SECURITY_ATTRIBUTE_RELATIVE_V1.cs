using System;
using static Smb.Core.Messages.MarshallingAttributes;

namespace Smb.Core.Models
{
    /// <summary>
    /// The CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 structure defines a resource attribute 
    /// that is defined in contiguous memory for persistence within a serialized Security Descriptor.
    /// </summary>
    internal struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
    {
        /// <summary>
        /// A DWORD value indicating an offset from the beginning of the CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 
        /// structure to a String of Unicode characters containing the name of the claim security attribute. 
        /// The String MUST be at least 4 bytes in length.
        /// </summary>
        public UInt32 Name;

        /// <summary>
        /// A union tag value indicating the type of information referred to by the Values member. The Values member 
        /// MUST be an array of offsets from the beginning of the CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 structure to 
        /// the specified ValueType. 
        /// </summary>
        public ValueTypeEnum ValueType;

        /// <summary>
        /// Reserved. This member MUST be set to zero when sent and MUST be ignored when received.
        /// </summary>
        public UInt16 Reserved;

        /// <summary>
        ///  Flags
        /// </summary>
        public FlagEnum Flags;

        /// <summary>
        /// The number of values contained in the Values member.
        /// </summary>
        public UInt32 ValueCount => (UInt32)Values?.Length;

        /// <summary>
        /// An array of offsets from the beginning of the CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 structure. Each offset indicates
        /// the location of a claim security attribute value of type specified in the ValueType member.
        /// </summary>
        [Size("ValueCount")]
        public UInt32[] Values;

        [Flags]
        public enum FlagEnum : UInt32
        {
            /// <summary>
            /// The CLAIM_SECURITY_ATTRIBUTE has been manually assigned.
            /// </summary>
            FCI_CLAIM_SECURITY_ATTRIBUTE_MANUAL = 0x00010000,

            /// <summary>
            /// The CLAIM_SECURITY_ATTRIBUTE has been determined by a central policy.
            /// </summary>
            FCI_CLAIM_SECURITY_ATTRIBUTE_POLICY_DERIVED = 0x00020000,

            /// <summary>
            /// This claim security attribute is not inherited across processes.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x00000001,

            /// <summary>
            /// The value of the claim security attribute is case sensitive. 
            /// This flag is valid for values that contain String types.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x00000002,

            /// <summary>
            /// Reserved for future use.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x00000004,

            /// <summary>
            /// The claim security attribute is disabled by default.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x00000008,

            /// <summary>
            /// Reserved for future use.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x00000010,

            /// <summary>
            /// The claim security attribute is mandatory.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x00000020
        }

        public enum ValueTypeEnum : ushort
        {
            /// <summary>
            /// Values member refers to an array of offsets to LONG64 value(s).
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x0001,

            /// <summary>
            /// Values member refers to an array of offsets to ULONG64 value(s).
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x0002,

            /// <summary>
            /// Values member refers to an array of offsets to Unicode character String value(s).
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x0003,

            /// <summary>
            /// The Values member refers to an array of offsets to CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_RELATIVE
            /// value(s) where the OctetString value is a SID string.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x0005,

            /// <summary>
            /// The Values member refers to an array of offsets to ULONG64 values where each element indicates a 
            /// Boolean value. The value 1 indicates TRUE, and the value 0 indicates FALSE.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x0006,

            /// <summary>
            /// Values member contains an array of CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_RELATIVE value(s) 
            /// as specified in section 2.4.10.2.
            /// </summary>
            CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x0010
        }
    }
}
