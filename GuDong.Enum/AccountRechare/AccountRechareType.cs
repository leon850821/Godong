using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.AccountRechare
{
    /// <summary>
    /// 充值类型
    /// </summary>
    public enum AccountRechareType
    {
        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")]
        Alipay = 1,
        /// <summary>
        /// 银联在线
        /// </summary>
        [Description("银联在线")]
        YLZX = 2,
        /// <summary>
        /// 线下充值
        /// </summary>
        [Description("线下充值")]
        XXCZ = 3,
        /// <summary>
        /// 双乾支付
        /// </summary>
        [Description("双乾支付")]
        SQZF = 4,
        /// <summary>
        /// 红包
        /// </summary>
        [Description("红包")]
        RedPacket = 10,
        /// <summary>
        /// 业绩
        /// </summary>
        [Description("业绩")]
        Performance = 11
    }
}
