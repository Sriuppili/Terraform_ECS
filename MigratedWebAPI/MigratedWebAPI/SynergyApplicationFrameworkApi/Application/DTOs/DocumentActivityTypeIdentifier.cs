using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum DocumentActivityTypeIdentifier
    {
        [EnumMember]
        Uploaded = 0,
        [EnumMember]
        Deleted = 1,
    }
}