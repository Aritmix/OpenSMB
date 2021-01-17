using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class ECHO_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// </summary>
        public UInt32 Reserved => 0;
    }
}
