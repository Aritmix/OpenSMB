namespace Smb.Core.Shared
{
    public enum ShareTypes
    {
        /// <summary>
        /// Disk drive
        /// </summary>
        STYPE_DISKTREE = 0x00000000,
        /// <summary>
        /// Print queue
        /// </summary>
        STYPE_PRINTQ = 0x00000001,
        /// <summary>
        /// Communication device
        /// </summary>
        STYPE_DEVICE = 0x00000002,
        /// <summary>
        /// Interprocess communication (IPC)
        /// </summary>
        STYPE_IPC = 0x00000003,
        /// <summary>
        /// A cluster share
        /// </summary>
        STYPE_CLUSTER_FS = 0x02000000,
        /// <summary>
        /// A Scale-Out cluster share
        /// </summary>
        STYPE_CLUSTER_SOFS = 0x04000000,
        /// <summary>
        /// A DFS share in a cluster
        /// </summary>
        STYPE_CLUSTER_DFS = 0x08000000
    }
}
