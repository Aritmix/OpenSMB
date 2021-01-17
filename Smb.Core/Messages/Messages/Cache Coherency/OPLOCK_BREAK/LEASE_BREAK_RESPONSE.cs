using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class LEASE_BREAK_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 36;
        /// <summary>
        /// </summary>
        public UInt16 Reserved => 0;

        public UInt32 Flags => 0;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] LeaseKey;

        public LEASE_BREAK_RESPONSE_STATES LeaseState;

        public UInt64 LeaseDuration;
    }


   
    internal enum LEASE_BREAK_RESPONSE_STATES : UInt32
    {
        SMB2_LEASE_NONE = 0x00,
        /// <summary>
        /// A read caching lease is granted.
        /// </summary>
        SMB2_LEASE_READ_CACHING = 0x01,
        /// <summary>
        /// A handle caching lease is granted.
        /// </summary>
        SMB2_LEASE_HANDLE_CACHING = 0x02,
        /// <summary>
        /// A write caching lease is granted.
        /// </summary>
        SMB2_LEASE_WRITE_CACHING = 0x04
    }
}
