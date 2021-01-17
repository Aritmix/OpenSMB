using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core.Messages.Message.Error
{
    /// <summary>
    /// ErrorId (4 bytes): An identifier for the error context. This field MUST be set to one of the following values.
    /// </summary>
    [Flags]
    internal enum ErrorId : UInt32
    {
        /// <summary>
        /// Unless otherwise specified, all errors defined in the [MS-SMB2] protocol use this error ID.
        /// </summary>
        SMB2_ERROR_ID_DEFAULT = 0x00000000,
        /// <summary>
        /// The ErrorContextData field contains a share redirect message described in section 2.2.2.2.2.
        /// </summary>
        SMB2_ERROR_ID_SHARE_REDIRECT = 0x72645253,
    }

    [StructLayout(layoutKind: LayoutKind.Sequential)]
    internal class ERROR_CONTEXT_RESPONSE
    {
        /// <summary>
        /// ErrorDataLength (4 bytes): The length, in bytes, of the ErrorContextData field.
        /// </summary>
        public UInt32 ErrorDataLength;
        /// <summary>
        /// ErrorId (4 bytes): An identifier for the error context. 
        /// </summary>
        public ErrorId ErrorId => 0;
        /// <summary>
        /// ErrorContextData (variable): Variable-length error data formatted as specified in section 2.2.2.2.
        /// </summary>
        public Byte[] ErrorContextData;    
        
    }
}
