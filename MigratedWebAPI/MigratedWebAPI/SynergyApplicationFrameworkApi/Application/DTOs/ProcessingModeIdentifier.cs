using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    [Serializable]
    public enum ProcessingModeIdentifier
    {
        [EnumMember]
        BestPractice = 1,
        [EnumMember]
        RelaxedProcessing = 2,
        [EnumMember]
        SystemLearning = 3,

    }
}
