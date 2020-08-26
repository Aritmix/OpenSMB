using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class QUERY_QUOTA_INFO
    {
        /// <summary>
        /// </summary>
        public Byte ReturnSingle;
        /// <summary>
        /// </summary>
        public Byte RestartScan;
        public UInt16 Reserved => 0;
        public UInt32 SidListLength;
        public UInt32 StartSidLength;
        public UInt32 StartSidOffset;
        public FILE_GET_QUOTA_INFORMATION[] SidBuffer;
    }
}