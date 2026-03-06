using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum ContainerMasterDefinitionTypeIdentifier
    {
        [EnumMember]
        [Description("Reprocessing")]
        Reprocessing = 1,

        [EnumMember]
        [Description("Blueprint")]
        Blueprint = 2,
    }
}
