using Smb.Core.Shared;
using System;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerConnectionOptions
    {
        /// <summary>
        ///  A Boolean that, if set, indicates that the server supports the multichannel capability.
        /// </summary>
        public Boolean IsMultiChannelCapable { get; set; }

        /// <summary>
        /// The maximum SMB dialect at which clients can access clustered shares on the server.
        /// </summary>
        public SMBDialects MaxClusterDialect { get; set; }

        /// <summary>
        /// A Boolean, if set, indicates the server supports the SMB2 TREE_CONNECT Request Extension
        /// </summary>
        public Boolean SupportsTreeConnectExtention { get; set; } = true;

    }
}
