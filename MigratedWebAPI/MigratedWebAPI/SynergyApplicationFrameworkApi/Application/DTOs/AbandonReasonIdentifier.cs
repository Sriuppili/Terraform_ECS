using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum AbandonReasonIdentifier
    {
        [EnumMember] 
        [Description("IUSS")]
        IUSS = 1,

        [EnumMember]
        [Description("Loan/Vendor Kit")]
        LoanVendorKit = 2,

        [EnumMember]
        [Description("Process Non-compliance")]
        ProcessNonCompliance = 3,

        [EnumMember]
        [Description("Other")]
        Other = 4,

        [EnumMember]
        [Description("Auto Abandon Non-com")]
        AutoAbandonNonCom = 4,
    }
}
