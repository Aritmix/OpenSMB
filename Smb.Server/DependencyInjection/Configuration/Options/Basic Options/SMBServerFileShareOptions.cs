using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerFileShareOptions
    {
        /// <summary>
        /// IP range with subnet EG. 10.42.0.1/8
        /// </summary>
        public Boolean Enabled{ get; set; }


        /// <summary>
        /// A Boolean that, if set, indicates that the server supports shared virtual disks.
        /// </summary>
        public Boolean IsSharedVHDSupported { get; set; }
    }
}
