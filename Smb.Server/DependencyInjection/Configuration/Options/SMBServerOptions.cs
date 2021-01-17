using Smb.Core;
using Smb.Core.Models;
using Smb.Core.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace Smb.Server.DependencyInjection.Configuration.Options
{
    public class SMBServerOptions     
    {
        public IPAddress ServerIP { get; set; }
        public IPAddress BroadcastIP { get; set; }
        public Int32 Port { get; set; }
        public String HostName { get; set; }
        public String Comment { get; set; }

        public SMBTransportTypes TransportType { get; set; } = SMBTransportTypes.DirectTCP;
        public Int32 InactivityMonitoringInterval { get; set; } = 30000;

        
        /// <summary>
        /// Workgroup or domain name
        /// </summary>
        public String Workgroup { get; set; } = "WORKGROUP";
        public SMBPrintServerOptions Print { get; set; }
        public SMBServerSecurityOptions Security { get; set; }
        public SMBServerFileShareOptions FileShare { get; set; }

        public SMBServerCompressionOptions Compression { get; set; }

        public SMBServerLeasingOptions Leasing { get; set; }

        /// <summary>
        ///  Server statistical information. This contains all the members of STAT_SRV_0  structure as specified in [MS-SRVS] section 2.2.4.39
        /// </summary>
        public STAT_SERVER_0 Statistics { get; set; }

        /// <summary>
        ///  A Boolean that indicates whether the SMB2 server is accepting incoming connections or requests.
        /// </summary>
        public Boolean ServerEnabled { get; set; }

        /// <summary>
        ///  A list of available shares for the system. The structure of a share is as specified in 
        ///  section 3.3.1.6 and is uniquely indexed by the tuple<Share.ServerName, Share.Name>.
        /// </summary>
        public Dictionary<string, SMBServerShare> ShareList { get; set; }

        /// <summary>
        /// A table containing all the files opened by remote clients on the server,
        /// indexed by Open.DurableFileId.The structure of an open is as specified in section 3.3.1.10. 
        /// The  table MUST support enumeration of all entries in the table.
        /// </summary>
        public int GlobalOpenTable { get; set; }

        /// <summary>
        /// A list of all the active sessions established to this server, indexed by the Session.SessionId.
        /// </summary>
        public int GlobalSessionTable { get; set; }

        /// <summary>
        ///  A list of all open connections on the server, indexed by the connection \endpoint addresses.
        /// </summary>
        private Collection<SMBServerConnection> ConnectionList { get; set; }

        /// <summary>
        /// A global identifier for this server
        /// </summary>
        public GUID ServerGuid { get; set; }

        /// <summary>
        /// The start time of the SMB2 server, in FILETIME format as specified in [MSDTYP] section 2.3.3.
        /// </summary>
        public FILETIME ServerStartTime { get; set; }

        /// <summary>
        ///  A Boolean that, if set, indicates that the server supports the Distributed File System.
        /// </summary>
        public int IsDfsCapable { get; set; }
        /// <summary>
        /// The maximum number of chunks the server will accept in a server side copy operation.
        /// </summary>
        public int ServerSideCopyMaxNumberofChunks { get; set; }
        /// <summary>
        /// The maximum number of bytes the server will accept in a single chunk for a server side copy operation.
        /// </summary>
        public int ServerSideCopyMaxChunkSize { get; set; }
        /// <summary>
        ///  The maximum total number of bytes the server will accept for a server side copy operation.
        /// </summary>
        public int ServerSideCopyMaxDataSize { get; set; }

        /// <summary>
        ///   A state that indicates the caching level configured on the server
        /// </summary>
        public ServerHashLevels HashLevel { get; set; }

        
    }
}
