using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Log
{
    public enum AppenderEnum
    {
        /// <summary>
        /// 应用报错记录专用
        /// </summary>
        [Description("Web应用报错记录专用")]
        WebErroLog,
    }
}
