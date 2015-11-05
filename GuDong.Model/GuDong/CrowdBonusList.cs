using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Model.GuDong
{
    public class CrowdBonusList
    {
        public Guid Id { get; set; }
        public Guid CrowdFunDingInfo_Id { get; set; }
        public Guid User_Id { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal BonusShare { get; set; }
        public DateTime BonusDate { get; set; }
        public virtual CrowdFunDingInfo CrowdFunDingInfo { get; set; }
    }
}
