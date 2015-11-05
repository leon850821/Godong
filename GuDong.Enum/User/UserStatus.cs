using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.User
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserStatus
    {
        /// <summary>
        /// 启用
        /// </summary>
        [Description("启用")]
        Start = 1,
        /// <summary>
        /// 冻结
        /// </summary>
        [Description("冻结")]
        Stop = 0
    }
}
