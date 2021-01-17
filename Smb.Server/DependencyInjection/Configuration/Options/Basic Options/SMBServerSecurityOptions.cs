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


        /// <summary>
        /// A Boolean that, if set, indicates that this node requires that messages
        /// MUST be signed if the message is sent with a user security context that is neither anonymous nor
        /// guest.If not set, this node does not require that any messages be signed, but can still choose to do so
        /// if the other node requires it.
        /// </summary>
        public Boolean RequireMessageSigning { get; set; }

        /// <summary>
        /// A Boolean; if set, indicates that encryption is supported by the node.
        /// </summary>
        public Boolean IsEncryptionSupported { get; set; }


        /// <summary>
        ///  A Boolean that, if set, indicates that the server requires messages to be encrypted 
        ///  after session establishment, per the conditions specified in section 3.3.5.2.9.
        /// </summary>
        public Boolean EncryptData { get; set; }

        /// <summary>
        /// A Boolean that, if set, indicates that the server will reject any unencrypted messages.
        /// This flag is applicable only if EncryptData is TRUE or if Share.EncryptData (as defined in section 3.3.1.6) is TRUE.
        /// </summary>
        public Boolean RejectUnencryptedAccess { get; set; }

    }
}
