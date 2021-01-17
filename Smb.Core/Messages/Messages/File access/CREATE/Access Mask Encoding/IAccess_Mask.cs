using System;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding
{
    public interface IAccess_Mask
    {
        UInt32 AccessMask { get; }
    }
}