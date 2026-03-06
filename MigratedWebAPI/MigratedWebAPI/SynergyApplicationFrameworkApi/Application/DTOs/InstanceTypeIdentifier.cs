using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum  InstanceTypeIdentifier
    {
        [EnumMember]
        Unknown = 0,
        [EnumMember]
        ContainerInstance = 1,
        [EnumMember]
        ItemInstance = 2,
    }
}
