namespace Smb.Core.Shared
{

    /// <summary>
    /// Service Name and Transport Protocol Port Number Registry
    /// <see cref="https://www.iana.org/assignments/service-names-port-numbers/service-names-port-numbers.xhtml"/>
    /// </summary>
    public enum SMBTransportTypes
    {
        /// <summary>
        /// microsoft-ds Port (0x01BD)
        /// </summary>
        DirectTCP = 445,
        /// <summary>
        /// netbios-ssn - NETBIOS Session Service
        /// </summary>
        NetBIOSOverTCP = 139,

        /// <summary>
        /// Server Message Block over Remote Direct Memory Access
        /// </summary>
        RemoteDirectMemoryAccess = 5445
    }
}
