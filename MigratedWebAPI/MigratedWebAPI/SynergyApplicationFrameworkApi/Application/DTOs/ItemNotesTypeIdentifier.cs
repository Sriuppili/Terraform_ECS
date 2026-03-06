using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public enum ItemNotesTypeIdentifier
    {
        [EnumMember]
        General = 1,
        [EnumMember]
        Operational = 2
    }
}