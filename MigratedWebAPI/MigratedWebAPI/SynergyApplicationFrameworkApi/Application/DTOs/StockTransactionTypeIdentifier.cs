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
    public enum StockTransactionTypeIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        [Description("Stock In")]
        StockIn = 1,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        [Description("Stock Out")]
        StockOut = 2,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        [Description("Move Stock")]
        MoveStock = 3
    }
}
