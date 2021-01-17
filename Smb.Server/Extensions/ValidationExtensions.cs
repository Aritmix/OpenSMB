using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Smb.Server.Extensions
{
    internal static class ValidationExtensions
    {
        [DebuggerStepThrough]
        public static bool IsEmpty(this String value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        [DebuggerStepThrough]
        public static bool HasValue(this String value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        [DebuggerStepThrough]
        public static bool IsEmpty(this IPAddress value)
        {
            return value == null;
        }

        [DebuggerStepThrough]
        public static bool HasValue(this IPAddress value)
        {
            return value != null;
        }
    }
}
