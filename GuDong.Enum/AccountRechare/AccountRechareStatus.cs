using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.AccountRechare
{
    /// <summary>
    /// 充值状态
    /// </summary>
    public enum AccountRechareStatus
    {
        /// <summary>
        /// 未审核
        /// </summary>
        [Description("未审核")]
        UnAudit = 1,
        /// <summary>
        /// 审核失败
        /// </summary>
        [Description("审核失败")]
        AuditLost = 2,
        /// <summary>
        /// 审核成功
        /// </summary>
        [Description("审核成功")]
        AuditSuccess = 3,
        /// <summary>
        /// 正在处理
        /// </summary>
        [Description("正在处理")]
        ZZCL = 4,
        /// <summary>
        /// 充值成功
        /// </summary>
        [Description("充值成功")]
        CZCG = 5,
        /// <summary>
        /// 充值失败0
        /// </summary>
        [Description("充值失败")]
        CZSB = 6,
        /// <summary>
        /// 未付款
        /// </summary>
        [Description("未付款")]
        WFK = 7
    }
}
