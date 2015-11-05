using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.CrowdInvestment
{
    public enum InvestmentType
    {
        /// <summary>
        /// 商家出资
        /// </summary>
        [Description("商家出资")]
        Merchant = 1,
        /// <summary>
        /// 用户出资
        /// </summary>
        [Description("用户出资")]
        User = 2,
    }
}
