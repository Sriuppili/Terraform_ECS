using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum DocumentTypeIdentifier
    {
        [EnumMember]
        Image = 0,
        [EnumMember]
        Document = 1,
    }
}
