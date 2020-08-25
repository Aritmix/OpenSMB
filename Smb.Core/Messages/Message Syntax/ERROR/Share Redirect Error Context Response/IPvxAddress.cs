using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    /// <summary>
    /// (IPv4Address/Reserved2)/ IPv6Address (16 bytes): 
    /// This field is interpreted in different ways depending on the value of the Type field.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct IPvxAddress
    {
        /// <summary>
        /// §	If the value of the Type field is MOVE_DST_IPADDR_V4, this field is the IPv4Address field followed by Reserved2 fields.
        /// 
        /// IPv4Address (4 bytes): 32-bit destination IPv4 address.
        /// </summary>
        [FieldOffset(0)] public UInt32 IPv4Address;
        /// <summary>
        /// Reserved2 (12 bytes): The server MUST set this to 0, and the client MUST ignore it on receipt.
        /// </summary>
        [FieldOffset(sizeof(UInt32))] public fixed Byte Reserved2[12];
        /// <summary>
        /// § If the value of the Type field is MOVE_DST_IPADDR_V6, this field is the IPv6Address field.
        /// IPv6Address (16 bytes): 128-bit destination IPv6 address.
        /// </summary>
        [FieldOffset(0)] public fixed UInt32 IPv6Address[16];
    }
}
