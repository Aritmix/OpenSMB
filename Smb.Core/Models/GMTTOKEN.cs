using System;
using System.Runtime.InteropServices;

namespace Smb.Core.Models
{
    /// <summary>
    /// A special token that can be present as part of a file path to indicate a request to see a previous version of the file or directory. 
    /// The format is "@GMT-YYYY.MM.DD-HH.MM.SS". 
    /// This 16-bit Unicode String represents a time and date in Coordinated Universal Time (UTC), with YYYY representing the year, MM the month, DD the day, HH the hour, MM the minute, and SS the seconds.
    /// </summary>
    internal struct GMTTOKEN
    {

        [MarshalAs(UnmanagedType.BStr, SizeConst = 16)]
        public String Value;
    }
}
