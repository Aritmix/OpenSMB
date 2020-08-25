using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Messages.Message_Syntax.CREATE
{
    internal interface ICreateContextBuffer
    {
        Byte[] Name { get; }
    }
}
