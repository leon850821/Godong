using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class FundAccountInfo
    {
        public System.Guid User_Id { get; set; }
        public decimal AviMoney { get; set; }
        public decimal FreezeAcount { get; set; }
        public int Integral { get; set; }
        public int FreezeIntegral { get; set; }
        public decimal RewardMoney { get; set; }
    }
}
