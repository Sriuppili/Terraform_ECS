using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum DefectStatusIdentifier : byte
    {
        [EnumMember]
        New = 1,
        [EnumMember]
        UnderInvestigation = 2,
        [EnumMember]
        UnderReview = 3,
        [EnumMember]
        Closed = 4,
    }
}
