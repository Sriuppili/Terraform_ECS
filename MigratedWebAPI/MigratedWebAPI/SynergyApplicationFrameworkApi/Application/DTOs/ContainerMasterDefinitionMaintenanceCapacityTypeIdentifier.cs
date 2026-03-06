using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum ContainerMasterDefinitionMaintenanceCapacityTypeIdentifier : byte
    {
        [EnumMember]
        MinimumInCirculation = 1,
        [EnumMember]
        MaximumInMaintenance = 2,
    }
}
