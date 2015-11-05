using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Log
{
    public interface ILogHelper
    {
        /// <summary>
        /// Web报错记录专用
        /// </summary>
        /// <param name="msg">错误描述</param>
        void WebErroLog(string msg);

    }
}
