using Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding;
using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Buffer_names
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CREATE_RESPONSE_LEASE : ICreateContextBuffer
    {
        public byte[] Name => CREATE_CONTEXT_RESPONSE_BUFFER_NAMES.CREATE_RESPONSE_LEASE;

        public Byte[] LeaseKey;
        /// <summary>
        /// LeaseState (4 bytes): The requested lease state. This field MUST be constructed as a combination.
        /// </summary>
        public LeaseResponseStates LeaseState;
        public LeaseResponseFlags LeaseResponseFlags;
        public UInt64 LeaseDuration => 0;

    }

    
    [Flags]
    internal enum LeaseResponseFlags : UInt32
    {
        NONE = 0x00,
        /// <summary>
        /// A break for the lease identified by the lease key is in progress.
        /// </summary>
        SMB2_LEASE_FLAG_BREAK_IN_PROGRESS = 0x02
    }


        [Flags]
    internal enum LeaseResponseStates : UInt32
    {
        /// <summary>
        /// No lease is requested.
        /// </summary>
        SMB2_LEASE_NONE = 0x00,
        /// <summary>
        /// A read caching lease is requested.
        /// </summary>
        SMB2_LEASE_READ_CACHING = 0x01,
        /// <summary>
        /// A handle caching lease is requested.
        /// </summary>
        SMB2_LEASE_HANDLE_CACHING = 0x02,
        /// <summary>
        /// A write caching lease is requested.
        /// </summary>
        SMB2_LEASE_WRITE_CACHING = 0x04
    }
}
