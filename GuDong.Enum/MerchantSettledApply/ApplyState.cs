using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.MerchantSettledApply
{
    public enum ApplyState
    {
        /// <summary>
        /// 未受理
        /// </summary>
        [Description("未受理")]
        NotAcceptance = 1,
        /// <summary>
        /// 已受理
        /// </summary>
        [Description("已受理")]
        Acceptance = 2
    }
}
