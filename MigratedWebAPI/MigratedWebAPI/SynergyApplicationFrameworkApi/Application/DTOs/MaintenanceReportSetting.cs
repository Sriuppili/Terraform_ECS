using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum MaintenanceReportSetting
    {
        [EnumMember]
        Off = 0,

        [EnumMember]
        On = 1,

        [EnumMember]
        Suspended = 2
    }
}
