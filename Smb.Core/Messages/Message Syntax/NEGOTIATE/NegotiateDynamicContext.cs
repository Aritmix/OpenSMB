using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// (NegotiateContextOffset/NegotiateContextCount/Reserved2)/ClientStartTime (8 bytes): 
    /// This field is interpreted in different ways depending on the SMB2 Dialects field.
    /// If the Dialects field contains 0x0311, this field is interpreted as the NegotiateContextOffset, NegotiateContextCount, and Reserved2 fields.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct NegotiateDynamicContext
    {
        /// <summary>
        /// NegotiateContextOffset (4 bytes): The offset, in bytes, from the beginning of the SMB2 header to the first, 8-byte-aligned negotiate context in the NegotiateContextList.
        /// </summary>
        [FieldOffset(0)] public UInt32 NegotiateContextOffset;
        /// <summary>
        /// NegotiateContextCount (2 bytes): The number of negotiate contexts in NegotiateContextList.
        /// </summary>
        [FieldOffset(sizeof(UInt16))] public UInt16 NegotiateContextCount;
        /// <summary>
        /// Reserved2 (2 bytes): The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        [FieldOffset(sizeof(UInt16) + sizeof(UInt32))] public UInt16 Reserved2;
        /// <summary>
        /// ClientStartTime (8 bytes):  This field MUST NOT be used and MUST be reserved. The client MUST set this to 0, and the server MUST ignore it on receipt.
        /// </summary>
        [FieldOffset(0)] public UInt64 ClientStartTime;
    }
}
