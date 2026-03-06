using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum KnownCustomerLabelType
    {
        [EnumMember]
        InstanceExternalId = 1,
        [EnumMember]
        AlternateInstanceId = 2,
    }
}
