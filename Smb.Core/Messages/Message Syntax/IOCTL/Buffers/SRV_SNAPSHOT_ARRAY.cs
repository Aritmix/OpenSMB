using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SRV_SNAPSHOT_ARRAY
    {
        public UInt32 NumberOfSnapShots;

        public UInt32 NumberOfSnapShotsReturned;
        public UInt32 SnapShotArraySize;
        public GMTTOKEN[] SnapShots;

    }
}
