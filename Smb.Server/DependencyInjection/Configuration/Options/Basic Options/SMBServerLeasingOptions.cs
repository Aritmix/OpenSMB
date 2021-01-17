using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerLeasingOptions
    {
        /// <summary>
        ///  A list of all the lease tables as described in 3.3.1.11, indexed by the ClientGuid.
        /// </summary>
        public String GlobalLeaseTableList { get; set; }

    }
}
