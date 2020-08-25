using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Models.Package
{
    internal interface IPacketBuffer
    {
        ushort BufferOffset { get; }
        uint BufferLength { get; }
    }
}
