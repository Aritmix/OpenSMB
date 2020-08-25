using System;
using System.Collections.Generic;
using System.Text;
using Smb.Core.Shared;

namespace Smb.Core.Messages.Message_Syntax.CREATE.Access_Mask_Encoding
{
    /// <summary>
    /// Buffer (variable): A variable-length buffer that contains the name and data fields; as defined by NameOffset; NameLength; DataOffset; and DataLength. The name is represented as four or more octets and MUST be one of the values provided in the following table. The structure name indicates what information is encoded by the data payload. The following values are the valid Create Context values and are defined to be in network byte order. More details are provided for each of these values in the following subsections.
    /// </summary>
    internal class CREATE_CONTEXT_REQUEST_BUFFER_NAMES
    {
        public static byte[] CREATE_EA_BUFFER => 0x45787441.GetLittleEndianBytes();
        public static byte[] CREATE_SD_BUFFER => 0x53656344.GetLittleEndianBytes();
        public static byte[] CREATE_DURABLE_HANDLE_REQUEST => 0x44486e51.GetLittleEndianBytes();
        public static byte[] CREATE_DURABLE_HANDLE_RECONNECT => 0x44486e43.GetLittleEndianBytes();
        public static byte[] CREATE_ALLOCATION_SIZE => 0x416c5369.GetLittleEndianBytes();
        public static byte[] CREATE_QUERY_MAXIMAL_ACCESS_REQUEST => 0x4d784163.GetLittleEndianBytes();
        public static byte[] CREATE_TIMEWARP_TOKEN => 0x54577270.GetLittleEndianBytes();
        public static byte[] CREATE_QUERY_ON_DISK_ID => 0x51466964.GetLittleEndianBytes();
        public static byte[] CREATE_REQUEST_LEASE => 0x52714c73.GetLittleEndianBytes();
        public static byte[] CREATE_REQUEST_LEASE_V2 => 0x52714c73.GetLittleEndianBytes();
        public static byte[] CREATE_DURABLE_HANDLE_REQUEST_V2 => 0x44483251.GetLittleEndianBytes();
        public static byte[] CREATE_DURABLE_HANDLE_RECONNECT_V2 => 0x44483243.GetLittleEndianBytes();
        public static byte[] CREATE_APP_INSTANCE_ID => "45BCA66AEFA7F74A9008FA462E144D74".GetLittleEndianBytes();
        public static byte[] CREATE_APP_INSTANCE_VERSION => "B982D0B73B56074FA07B524A8116A010".GetLittleEndianBytes();
        public static byte[] SVHDX_OPEN_DEVICE_CONTEXT => "9CCBCF9E04C1E643980E158DA1F6EC83".GetLittleEndianBytes();
    }
}
