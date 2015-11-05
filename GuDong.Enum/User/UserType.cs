using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.User
{
    public enum UserType
    {
        /// <summary>
        /// 个人
        /// </summary>
        [Description("个人")]
        Personage = 1,
        /// <summary>
        /// 企业用户
        /// </summary>
        [Description("企业用户")]
        Company = 2,
        /// <summary>
        /// 员工
        /// </summary>
        [Description("员工")]
        Staff = 3,
         /// <summary>
        /// 咕咚注册用户
        /// </summary>
        [Description("咕咚注册用户")]
        GuDongUser = 4,
         /// <summary>
        /// 咕咚注册商家
        /// </summary>
        [Description("咕咚注册商家")]
        GuDongShangJia = 5
    }
}
