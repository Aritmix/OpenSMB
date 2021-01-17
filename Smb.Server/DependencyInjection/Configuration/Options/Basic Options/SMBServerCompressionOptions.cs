using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerCompressionOptions
    {
        /// <summary>
        ///  A Boolean; if set, indicates that compression is supported by the node.
        /// </summary>
        public Boolean IsCompressionSupported { get; set; }
        /// <summary>
        /// A Boolean; if set, indicates that chained compression is supported.
        /// </summary>
        public Boolean IsChainedCompressionSupported { get; set; }
    }
}
