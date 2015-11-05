using GuDong.Enum.CrowdFunDingInfo;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface ICrowdFunDingInfo : IComm<CrowdFunDingInfo>
    {
        /// <summary>
        /// 统计已完成项目数
        /// </summary>
        /// <returns></returns>
        int CountCompleteNum();

        /// <summary>
        /// 获取首页众筹板块数据
        /// </summary>
        /// <returns></returns>
        List<CrowdFunDingInfo> HomeCategoryList();

        /// <summary>
        /// 获取众筹进行时列表
        /// </summary>
        /// <param name="Page"></param>
        /// <param name="Lmit"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        List<CrowdFunDingInfo> List(int Page, int Limit, CrowdState Type);


        



    }
}
