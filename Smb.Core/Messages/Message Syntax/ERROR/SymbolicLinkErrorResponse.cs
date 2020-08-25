using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Smb.Core
{

    [Flags]
    public enum SymbolicLinkErrorResponseFlags : UInt32
    {
        /// <summary>
        /// The substitute name is an absolute target path name.
        /// </summary>
        SYMLINK_FLAG_ABSOLUTE = 0x00000000,
        /// <summary>
        /// When this Flags value is set, the substitute name is a path name relative to the directory containing the symbolic link.
        /// </summary>
        SYMLINK_FLAG_RELATIVE = 0x00000001
    }

    [StructLayout(layoutKind: LayoutKind.Sequential)]
    public class SymbolicLinkErrorResponse
    {
        /// <summary>
        /// SymLinkLength (4 bytes): The length, in bytes, of the response including the variable-length portion and excluding SymLinkLength.
        /// </summary>
        public UInt32 SymLinkLength;
        /// <summary>
        /// SymLinkErrorTag (4 bytes): The server MUST set this field to 0x4C4D5953.
        /// </summary>
        public UInt32 SymLinkErrorTag => 0x4C4D5953;
        /// <summary>
        /// ReparseTag (4 bytes): The type of link encountered. 
        /// The server MUST set this field to 0xA000000C.
        /// </summary>
        public UInt32 ReparseTag => 0xA000000C;
        /// <summary>
        /// ReparseDataLength (2 bytes): The length, in bytes, of the variable-length portion of the symbolic link error response plus the size of the static portion, not including SymLinkLength, SymLinkErrorTag, ReparseTag, ReparseDataLength, and UnparsedPathLength. 
        /// The server MUST set this to the size of PathBuffer[], in bytes, plus 12. (12 is the size of SubstituteNameOffset, SubstituteNameLength, PrintNameOffset, PrintNameLength, and Flags.)
        /// </summary>
        public UInt16 ReparseDataLength;
        /// <summary>
        /// UnparsedPathLength (2 bytes): The length, in bytes, of the unparsed portion of the path. 
        /// The unparsed portion is the remaining part of the path after the symbolic link. 
        /// See section 2.2.2.2.1.1 for examples.
        /// </summary>
        public UInt16 UnparsedPathLength;
        /// <summary>
        /// SubstituteNameOffset (2 bytes): The offset, in bytes, from the beginning of the PathBuffer field, at which the substitute name is located. 
        /// The substitute name is the name the client MUST use to access this file if it requires to follow the symbolic link.
        /// </summary>
        public UInt16 SubstituteNameOffset;
        /// <summary>
        /// SubstituteNameLength (2 bytes): The length, in bytes, of the substitute name string. If there is a terminating null character at the end of the string, it is not included in the SubstituteNameLength count. 
        /// This value MUST be greater than or equal to 0.
        /// </summary>
        public UInt16 SubstituteNameLength;
        /// <summary>
        /// PrintNameOffset (2 bytes): The offset, in bytes, from the beginning of the PathBuffer field, at which the print name is located.
        /// The print name is the user-friendly name the client MUST return to the application if it requests the name of the symbolic link target.
        /// </summary>
        public UInt16 PrintNameOffset;
        /// <summary>
        /// PrintNameLength (2 bytes): The length, in bytes, of the print name string. If there is a terminating null character at the end of the string, it is not included in the PrintNameLength count. 
        /// This value MUST be greater than or equal to 0.
        /// </summary>
        public UInt16 PrintNameLength;
        /// <summary>
        /// Flags (4 bytes): A 32-bit bit field that specifies whether the substitute is an absolute target path name or a path name relative to the directory containing the symbolic link.
        /// </summary>
        public SymbolicLinkErrorResponseFlags Flags;

        /// <summary>
        /// PathBuffer (variable): A buffer that contains the Unicode strings for the substitute name and the print name, as described by SubstituteNameOffset, SubstituteNameLength, PrintNameOffset, and PrintNameLength. The substitute name string MUST be a Unicode path to the target of the symbolic link. The print name string MUST be a Unicode string, suitable for display to a user, that also identifies the target of the symbolic link.
        /// §	For an absolute target that is on a remote machine, the server MUST return the path in the format "\??\UNC\server\share\..." where server is replaced by the target server name, share is replaced by the target share name, and ... is replaced by the remainder of the path to the target.
        /// §	The server SHOULD NOT return symbolic link information with an absolute target that is a local resource, because local evaluation will vary based on client operating system (OS).<6>
        /// §	For a relative target, the server MUST return a path that does not start with "\". The path MUST be evaluated, by the calling application, relative to the directory containing the symbolic link. The path can contain either "." to refer to the current directory or ".." to refer to the parent directory, and could contain multiple elements.
        /// For more information on absolute and relative targets, see Handling the Symbolic Link Error Response (section 2.2.2.2.1.1).
        /// </summary>
        public Byte[] PathBuffer;
    }
}
