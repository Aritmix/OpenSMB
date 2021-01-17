using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerResilientOptions
    {
        /// <summary>
        ///  The maximum resiliency time-out in milliseconds, for the TimeOut field 
        ///  of NETWORK_RESILIENCY_REQUEST Request, as specified in section 2.2.31.3.
        /// </summary>
        public Int32 MaxResiliencyTimeout { get; set; }

        /// <summary>
        ///  The time at which the Resilient Open Scavenger Timer, as specified in section 3.3.2.4, is currently set to expire.
        /// </summary>
        public Int32 ResilientOpenScavengerExpiryTime { get; set; }

    }
}
