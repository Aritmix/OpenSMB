using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerSecurityOptions
    {
        /// <summary>
        /// IP range with subnet EG. 10.42.0.1/8
        /// </summary>
        public String AllowedHostsAndNetworks { get; set; }

        public int AuthenticationMechanism { get; set; }
    }
}
