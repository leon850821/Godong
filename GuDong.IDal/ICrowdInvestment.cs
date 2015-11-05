using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface ICrowdInvestment : IComm<CrowdInvestment>
    {
        /// <summary>
        /// 获取最新投资前五位
        /// </summary>
        /// <returns></returns>
        List<CrowdInvestment> GetDateDescTop5();
    }
}
