using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum ChargeListCategoryIdentifier
    {
        [EnumMember]
        ChangeControlNote = 1,

        [EnumMember]
        BarcodeReplacement = 2,

        [EnumMember]
        DeliveryCharge = 3,
    }
}
