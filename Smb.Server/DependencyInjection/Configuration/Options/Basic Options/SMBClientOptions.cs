using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration.Options
{

    //TODO: modify so it can be injected during setup
    public class SMBClientOptions
    {
        /// <summary>
        /// range: from 512 to 65535
        /// </summary>
        public ushort MaxBufferSize { get; set; } = 65535;

        public ushort MaxTransactSize { get; set; } = 1;
        public ushort MaxReadSize { get; set; } = 1;

        
    }
}
