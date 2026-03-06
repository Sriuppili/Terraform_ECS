using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{

    [Serializable]
    public enum AuditLineExceptionReasonIdentifier
    {
        [EnumMember]
        BarcodeWontScan = 1,
        [EnumMember]
        NotPresent = 2
    }
}
