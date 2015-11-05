using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface IIndustryInfo : IComm<IndustryInfo>
    {
        /// <summary>
        /// 获取咕咚涉及行业
        /// </summary>
        /// <returns></returns>
        List<IndustryInfo> InvolveIndustry();
    }
}
