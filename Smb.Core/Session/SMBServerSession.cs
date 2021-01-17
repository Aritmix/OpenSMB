using Smb.Core.Shared;
using System.Collections.ObjectModel;

namespace Smb.Core.Session
{
    public class SMBServerSession
    {
        /// <summary>
        /// Indicates the state of the Session – Expired, InProgress or Completed.
        /// </summary>
        public SessionState AuthenticationState { get; set; }

        /// <summary>
        /// The UID associated with this Session.
        /// </summary>
        public ushort UID { get; set; }

        /// <summary>
        /// The user's security context associated with this session, as obtained from the authentication packages
        /// after successful authentication.
        /// </summary>
        public byte[] SecurityContext { get; set; }

        /// <summary>
        /// The 16-byte session key associated with this session, as obtained from the authentication packages after 
        /// successful authentication.
        /// </summary>
        public byte[] SessionKey { get; set; }

        /// <summary>
        /// The session key state. This can be either Unavailable or Available.
        /// </summary>
        public SessionKeyStateValue SessionKeyState { get; set; }

        /// <summary>
        /// The connection on which the session was established as specified in section 3.3.5.5.1.
        /// </summary>
        public SMBServerConnection Connection { get; set; }


        public Collection<SMBServerTreeConnect> TreeConnectTable { get; set; }

    }
}
