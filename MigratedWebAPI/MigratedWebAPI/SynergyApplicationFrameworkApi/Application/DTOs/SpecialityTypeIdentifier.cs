using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum SpecialityTypeIdentifier
    {   
        [EnumMember]
        [Description("None")]
        None = 1,

        [EnumMember]
        [Description("General")]
        General = 13,
    }
}
