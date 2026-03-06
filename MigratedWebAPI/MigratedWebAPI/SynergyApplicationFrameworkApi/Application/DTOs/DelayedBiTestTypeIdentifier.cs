using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum DelayedBiTestTypeIdentifier
    {
        [EnumMember] 
        Off = 1,

        [EnumMember]
        AfterSettingIncubation = 2,

        [EnumMember]
        BeforeSettingIncubation = 3,
    }
}
