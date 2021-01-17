using System;

namespace Smb.Core.Models
{
    /// <summary>
    /// Server Application Requests Server Statistics
    /// <see cref="https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-srvs/d54c2739-eb74-46c3-9224-50294ccc5d4d"/>
    /// </summary>
    public struct STAT_SERVER_0
    {
        public UInt32 sts0_start => 0;
        public UInt32 sts0_fopens { get; set; }
        public UInt32 sts0_devopens => 0;
        public UInt32 sts0_jobsqueued { get; set; }
        public UInt32 sts0_sopens { get; set; }
        public UInt32 sts0_stimedout { get; set; }
        public UInt32 sts0_serrorout => 0;
        public UInt32 sts0_pwerrors { get; set; }
        public UInt32 sts0_permerrors { get; set; }
        public UInt32 sts0_syserrors => 0;
        public UInt32 sts0_bytessent_low { get; set; }
        public UInt32 sts0_bytessent_high { get; set; }
        public UInt32 sts0_bytesrcvd_low { get; set; }
        public UInt32 sts0_bytesrcvd_high { get; set; }
        public UInt32 sts0_avresponse => 0;
        public UInt32 sts0_reqbufneed => 0;
        public UInt32 sts0_bigbufneed => 0;
    }
}
