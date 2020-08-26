using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// The SMB2 LOGOFF Response packet is sent by the server to confirm that an SMB2 LOGOFF Request (section 2.2.7) was completed successfully. This response is composed of an SMB2 header, as specified in section 2.2.1, followed by this request structure:
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class LEASE_BREAK_NOTIFICATION
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 44;
        /// <summary>
        /// </summary>
        public UInt16 NewEpoch;

        public LEASE_BREAK_NOTIFICATION_LEVELS Flags;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] LeaseKey;

        public LEASE_BREAK_CURRENT_STATES CurrentLeaseState;
        public LEASE_BREAK_NEW_STATES NewLeaseState;

        public UInt32 BreakReason => 0;
        public UInt32 AccessMaskHint => 0;
        public UInt32 ShareMaskHint => 0;
    }


    internal enum LEASE_BREAK_NOTIFICATION_LEVELS : UInt32
    {
        /// <summary>
        /// No oplock is available.
        /// </summary>
        NONE = 0x00,
        /// <summary>
        /// A level II oplock is available.
        /// </summary>
        SMB2_NOTIFY_BREAK_LEASE_FLAG_ACK_REQUIRED = 0x01
    }
    internal enum LEASE_BREAK_CURRENT_STATES : UInt32
    {
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

    internal enum LEASE_BREAK_NEW_STATES : UInt32
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
