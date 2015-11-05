using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.CodeRecord
{
   public enum CodeRecordStatus
    {
        /// <summary>
        /// 未使用
        /// </summary>
        [Description("未使用")]
        NotUse=1,
        /// <summary>
        /// 已使用
        /// </summary>
        [Description("已使用")]
        Used = 2
    }
}
