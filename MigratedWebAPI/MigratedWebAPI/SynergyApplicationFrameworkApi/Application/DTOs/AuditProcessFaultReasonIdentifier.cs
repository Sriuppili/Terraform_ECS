using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum AuditProcessFaultReasonIdentifier
    {
        [EnumMember]
        ItemRequiredDuplicateScan = 1,
        [EnumMember]
        ItemNotRequiredDuplicateScan = 2

    }
}
