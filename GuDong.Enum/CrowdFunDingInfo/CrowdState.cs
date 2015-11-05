using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.CrowdFunDingInfo
{
   public enum  CrowdState
    {
        /// <summary>
        /// 审核中
        /// </summary>
        [Description("审核中")]
        Checking = 1,
        /// <summary>
        /// 预热中
        /// </summary>
        [Description("预热中")]
        Preheat = 2,
        /// <summary>
        /// 众筹中
        /// </summary>
        [Description("众筹中")]
        Crowding = 3,
        /// <summary>
        /// 众筹成功
        /// </summary>
        [Description("众筹成功")]
        CrowdSucces = 4,
        /// <summary>
        /// 众筹失败
        /// </summary>
        [Description("众筹失败")]
        CrowdFail = 5,
        /// <summary>
        /// 分红状态
        /// </summary>
        [Description("分红状态")]
        Bonus = 6,

    }
}
