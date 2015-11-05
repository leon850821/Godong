using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.User
{
    /// <summary>
    /// 用户等级类型
    /// </summary>
    public enum UserLevelType
    {
        /// <summary>
        /// 普通用户
        /// </summary>
        [Description("普通用户")]
        Common = 1,
        /// <summary>
        /// VIP用户
        /// </summary>
        [Description("VIP用户")]
        VIP = 2
    }
}
