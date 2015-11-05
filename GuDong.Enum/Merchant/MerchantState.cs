using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.Merchant
{
    public enum MerchantState
    {
        /// <summary>
        /// 审核中
        /// </summary>
        [Description("审核中")]
        Checking = 1,
        /// <summary>
        /// 审核通过
        /// </summary>
        [Description("审核通过")]
        Checked = 2,
    }
}
