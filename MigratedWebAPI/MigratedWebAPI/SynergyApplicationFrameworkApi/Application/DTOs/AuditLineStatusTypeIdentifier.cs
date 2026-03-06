using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{

    [Serializable]
    public enum AuditLineStatusTypeIdentifier
    {
        [EnumMember]
        Present = 1,
        [EnumMember]
        Missing = 2,
        [EnumMember]
        AdditionalRecognised = 3,
        [EnumMember]
        AdditionalUnknown = 4,
        [EnumMember]
        ExceedsSpecification = 5

    }
}
