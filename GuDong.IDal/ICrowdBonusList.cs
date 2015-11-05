using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface ICrowdBonusList : IComm<CrowdBonusList>
    {
        /// <summary>
        /// 统计累积分红金额
        /// </summary>
        /// <returns></returns>
        decimal? CountBonusAmount();
    }
}
