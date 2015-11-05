using GuDong.EF.GoodJr;
using GuDong.EF.GuDong;
using GuDong.Enum.CrowdFunDingInfo;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class CrowdFunDingInfoDal : Comm<CrowdFunDingInfo>, ICrowdFunDingInfo
    {

        public int CountCompleteNum()
        {
            return ct.Set<CrowdFunDingInfo>().Count(x => x.CrowdState == CrowdState.CrowdSucces || x.CrowdState == CrowdState.Bonus);
        }

        public List<CrowdFunDingInfo> HomeCategoryList() {
            var data = new List<CrowdFunDingInfo>();
            var shuju = ct.Set<CrowdFunDingInfo>().Select(x => new
            {
                CrowdSucces = ct.Set<CrowdFunDingInfo>().Where(t => t.CrowdState == CrowdState.CrowdSucces).Take(6),
                Crowding = ct.Set<CrowdFunDingInfo>().Where(t => t.CrowdState == CrowdState.Crowding).Take(6),
                Preheat = ct.Set<CrowdFunDingInfo>().Where(t => t.CrowdState == CrowdState.Preheat).Take(6),

            }).FirstOrDefault();
            if (shuju != null)
            {
                data.AddRange(shuju.CrowdSucces);
                data.AddRange(shuju.Crowding);
                data.AddRange(shuju.Preheat);
            }
            return data;
        }

        public List<CrowdFunDingInfo> List(int Page, int Limit, CrowdState Type)
        {
            var data = ct.Set<CrowdFunDingInfo>()
                .Include("MerchantBasicInfo.IndustryInfo")
                .Where(x => x.CrowdState == Type)
                .OrderBy(x => x.CreateDate);
            this.TotalCount = data.Count();
            return data.Skip((Page - 1) * Limit).Take(Limit).ToList();
        }
    }
}
