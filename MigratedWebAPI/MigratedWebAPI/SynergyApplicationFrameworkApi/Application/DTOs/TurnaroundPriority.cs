using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum TurnaroundPriority
    {
        [EnumMember]
        Null = 0,
        [EnumMember]
        Low = 1,
        [EnumMember]
        Medium = 2,
        [EnumMember]
        High = 3
    }
}
