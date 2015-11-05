using GuDong.EF.GoodJr;
using GuDong.EF.GuDong;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class IndustryInfoDal : Comm<IndustryInfo>, IIndustryInfo
    {

        public List<IndustryInfo> InvolveIndustry()
        {
            ct.Configuration.LazyLoadingEnabled = true;
            return ct.Set<IndustryInfo>().Where(x => x.MerchantBasicInfoes.Count() > 0)
                .Select(x=>new {
                    Id = x.Id,
                    IndustryIco=x.IndustryIco,
                    IndustryName = x.IndustryName
                }).ToList()
                .Select(x => new IndustryInfo()
                {
                    Id = x.Id,
                    IndustryIco=x.IndustryIco,
                    IndustryName = x.IndustryName
                })
                .ToList();
        }
    }
}
