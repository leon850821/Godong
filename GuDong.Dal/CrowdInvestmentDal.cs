using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class CrowdInvestmentDal : Comm<CrowdInvestment>, ICrowdInvestment
    {

        public List<CrowdInvestment> GetDateDescTop5()
        {
            return ct.Set<CrowdInvestment>().Include("CrowdFunDingInfo").OrderByDescending(x => x.InvestmentDate).Take(5).ToList();
        }
    }
}
