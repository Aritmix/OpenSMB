﻿using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    /// <summary>
    /// </summary>
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class CANCEL_REQUEST
    {
        /// <summary>
        /// </summary>
        public UInt16 StructureSize => 4;
        /// <summary>
        /// </summary>
        public UInt32 Reserved => 0;
    }
}
