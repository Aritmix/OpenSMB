using System;

namespace Smb.Core.Models.Package
{
    /// <summary>
    /// Smb2Packet is the class which every single smb2 packet will inherit
    /// </summary>
    public abstract class Smb2Packet : IPacket
    {
        public object AssociatedObject
        {
            get;
            set;
        }

 
        /// <summary>
        /// Build a Smb2Packet from a byte array
        /// </summary>
        /// <param name="data">The byte array</param>
        /// <param name="consumedLen">The consumed data length</param>
        /// <param name="expectedLen">The expected data length</param>
        internal abstract void FromBytes(byte[] data, out int consumedLen, out int expectedLen);
    }
}