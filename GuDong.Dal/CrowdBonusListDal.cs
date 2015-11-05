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
    public class CrowdBonusListDal : Comm<CrowdBonusList>, ICrowdBonusList
    {

        public decimal? CountBonusAmount()
        {
            return  ct.Set<CrowdBonusList>().Sum(x => (decimal?)x.BonusAmount);;
        }
    }
}
