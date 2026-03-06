using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum FdaComplianceReasons
    {
        [EnumMember]
        [Description("1")]
        Review = 1,
        [EnumMember]
        [Description("2")]
        Approval = 2,
        [EnumMember]
        [Description("3")]
        Responsibility = 3,
    }
}
