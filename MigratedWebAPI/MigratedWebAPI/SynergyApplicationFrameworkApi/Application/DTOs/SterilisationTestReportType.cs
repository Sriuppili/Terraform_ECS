using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{  
    [Serializable]
    public enum SterilisationTestReportType :byte 
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Unknown = 0,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Daily = 1,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Weekly=2

    }
 
}
