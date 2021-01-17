namespace Smb.Core.Shared
{
    /// <summary>
    /// If the server implements the SMB 2.1 or SMB 3.x dialect family, it MUST implement the following:
    /// </summary>
    public enum ServerHashLevels
    {
        /// <summary>
        ///  Indicates that caching is enabled for all shares on the server
        /// </summary>
        HashEnableAll,
        /// <summary>
        ///  Indicates that caching is disabled for all shares on the server.
        /// </summary>
        HashDisableAll,
        /// <summary>
        ///  Indicates that caching is enabled or disabled on a per-share basis
        /// </summary>
        HashEnableShare
    }
}
