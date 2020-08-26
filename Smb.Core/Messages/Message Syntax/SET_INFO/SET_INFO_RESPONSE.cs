using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class SET_INFO_RESPONSE
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 2;
    }
}
