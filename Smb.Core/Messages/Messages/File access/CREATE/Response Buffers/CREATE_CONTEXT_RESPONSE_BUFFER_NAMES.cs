using System;
using System.Collections.Generic;
using System.Text;
using Smb.Core.Shared;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding
{
    /// <summary>
    /// Buffer (variable): A variable-length buffer that contains the name and data fields; as defined by NameOffset; NameLength; DataOffset; and DataLength. The name is represented as four or more octets and MUST be one of the values provided in the following table. The structure name indicates what information is encoded by the data payload. The following values are the valid Create Context values and are defined to be in network byte order. More details are provided for each of these values in the following subsections.
    /// </summary>
    internal class CREATE_CONTEXT_RESPONSE_BUFFER_NAMES
    {
        public static byte[] CREATE_DURABLE_HANDLE_RESPONSE => 0x44486e51.GetLittleEndianBytes();
        public static byte[] CREATE_QUERY_MAXIMAL_ACCESS_RESPONSE => 0x4d784163.GetLittleEndianBytes();
        public static byte[] CREATE_QUERY_ON_DISK_ID => 0x51466964.GetLittleEndianBytes();
        public static byte[] CREATE_RESPONSE_LEASE => 0x52714c73.GetLittleEndianBytes();
        public static byte[] CREATE_RESPONSE_LEASE_V2 => 0x52714c73.GetLittleEndianBytes();
        public static byte[] CREATE_DURABLE_HANDLE_RESPONSE_V2 => 0x44483251.GetLittleEndianBytes();
        public static byte[] SVHDX_OPEN_DEVICE_CONTEXT_RESPONSE => "9CCBCF9E04C1E643980E158DA1F6EC83".GetLittleEndianBytes();
    }
}
