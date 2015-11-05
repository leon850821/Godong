using GuDong.Enum.CodeRecord;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface ICodeRecord : IComm<CodeRecord>
    {
        /// <summary>
        /// 给手机发送验证码
        /// </summary>
        /// <param name="ToNumber">手机号码</param>
        /// <param name="Type">发送类型</param>
        /// <returns></returns>
        bool SendSmsCode(string ToNumber, CodeRecordType Type);
    }
}
