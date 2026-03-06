using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum ShelfStatus
    {
        [EnumMember]
        Ready,

        [EnumMember]
        Loading,

        [EnumMember]
        Loaded,

        [EnumMember]
        Selected
    }
}
