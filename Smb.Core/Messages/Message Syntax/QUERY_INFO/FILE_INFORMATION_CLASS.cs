﻿using System;
using System.Runtime.InteropServices;

namespace Smb.Core
{
    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class FILE_INFORMATION_CLASS
    {
        /// <summary>
        /// </summary>
        public UInt32 NextEntryOffset;
        /// <summary>
        /// </summary>
        public Byte EaNameLength;

        /// <summary>
        /// EaName (variable): An array of 8-bit ASCII characters that contains the extended attribute name followed by a single terminating null character byte.
        /// </summary>
        public Byte EaName;
    }
}