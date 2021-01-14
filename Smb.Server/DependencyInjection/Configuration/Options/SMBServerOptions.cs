using System;
using System.Net;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerOptions     
    {
        public IPAddress ServerIP { get; set; }
        public IPAddress BroadcastIP { get; set; }
        public Int32 Port { get; set; }
        public String HostName { get; set; }
        public String Comment { get; set; }

        public int SMBTransportType { get; set; }
        /// <summary>
        /// Workgroup or domain name
        /// </summary>
        public String Workgroup { get; set; }
        public SMBPrintServerOptions Print { get; set; }
        public SMBServerSecurityOptions Security { get; set; }
        public SMBServerFileShareOptions FileShare { get; set; }
    }
}
