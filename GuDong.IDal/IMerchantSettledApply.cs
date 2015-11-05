using GuDong.Enum.Comm;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface IMerchantSettledApply : IComm<MerchantSettledApply>
    {
        /// <summary>
        /// 商家申请入驻
        /// </summary>
        /// <param name="TelNo">手机号码</param>
        /// <param name="RealName">姓名</param>
        /// <param name="Sex">性别</param>
        /// <returns></returns>
        MerchantSettledApply AddApply(string TelNo, string RealName, SexType Sex);
    }
}
