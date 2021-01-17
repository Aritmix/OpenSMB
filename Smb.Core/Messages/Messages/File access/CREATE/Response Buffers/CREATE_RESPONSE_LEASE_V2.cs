using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_RESPONSE_LEASE_V2 : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_RESPONSE_BUFFER_NAMES.CREATE_RESPONSE_LEASE_V2;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] LeaseKey;

        /// <summary>
        /// LeaseState (4 bytes): The requested lease state. This field MUST be constructed as a combination.
        /// </summary>
        public LeaseV2ReponseStates LeaseState;

        public LeaseV2ResponseFlags LeaseFlags;

        public UInt64 LeaseDuration => 0;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public Byte[] ParentLeaseKey;

        public UInt16 Epoch;
        public UInt16 Reserved => 0;
    }

    [Flags]
    public enum LeaseV2ReponseStates : UInt32
    {
        /// <summary>
        /// No lease is requested.
        /// </summary>
        SMB2_LEASE_NONE = 0x00000000,
        /// <summary>
        /// A read caching lease is requested.
        /// </summary>
        SMB2_LEASE_READ_CACHING = 0x00000001,
        /// <summary>
        /// A handle caching lease is requested.
        /// </summary>
        SMB2_LEASE_HANDLE_CACHING = 0x00000002,
        /// <summary>
        /// A write caching lease is requested.
        /// </summary>
        SMB2_LEASE_WRITE_CACHING = 0x00000004
    }

    [Flags]
    public enum LeaseV2ResponseFlags : UInt32
    {
        NONE = 0x00000000,

        LEASE_FLAG_BREAK_IN_PROGRESS = 0x00000002,
        LEASE_FLAG_PARENT_LEASE_KEY_SET = 0x00000004
    }
}
