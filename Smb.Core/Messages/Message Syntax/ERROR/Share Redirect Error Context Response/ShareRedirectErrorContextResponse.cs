using Smb.Core.Shared;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class ShareRedirectErrorContextResponse
    {
        /// <summary>
        /// StructureSize (4 bytes): This field MUST be set to the size of the structure.
        /// </summary>
        public UInt32 StructureSize;
        /// <summary>
        /// NotificationType (4 bytes): This field MUST be set to 3.
        /// </summary>
        public UInt32 NotificationType => 0x00000003;
        /// <summary>
        /// ResourceNameOffset (4 bytes): The offset from the start of this structure to the ResourceName field.
        /// </summary>
        public UInt32 ResourceNameOffset => 0xA000000C;
        /// <summary>
        /// ResourceNameLength (4 bytes): The length of the share name provided in the ResourceName field, in bytes.
        /// </summary>
        public UInt32 ResourceNameLength;
        /// <summary>
        /// Flags(2 bytes) : This field MUST be set to zero.
        /// </summary>
        public UInt16 Flags => 0;
        /// <summary>
        /// TargetType (2 bytes): This field MUST be set to zero.
        /// </summary>
        public UInt16 TargetType => 0;
        /// <summary>
        /// IPAddrCount (4 bytes): The number of MOVE_DST_IPADDR structures in the IPAddrMoveList field.
        /// </summary>
        public UInt32 IPAddrCount => (UInt32)IPAddrMoveList.Length;
        /// <summary>
        /// IPAddrMoveList (variable): Array of MOVE_DST_IPADDR structures, as specified in section 2.2.2.2.2.1.
        /// </summary>
        public MOVE_DST_IPADDR[] IPAddrMoveList;
        /// <summary>
        /// ResourceName (variable): Name of the share as a counted Unicode string, as specified in [MS-DTYP] section 2.3.10. 
        /// </summary>
        public Byte[] ResourceName { get; private set; }
        public void SetResourceName(String str)
        {
            ResourceName = str.GetLittleEndianBytes();
        }
    }
}
