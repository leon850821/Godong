using GuDong.Enum.CrowdInvestment;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CrowdInvestment
    {
        public Guid Id { get; set; }
        public Guid CrowdFunDingInfo_Id { get; set; }
        public System.Guid User_Id { get; set; }
        public InvestmentType InvestmentType { get; set; }
        public int InvestmentShare { get; set; }
        public decimal InvestmentAmount { get; set; }
        public decimal ProportionOf { get; set; }
        public decimal DividendsOf { get; set; }
        public System.DateTime InvestmentDate { get; set; }
        public virtual CrowdFunDingInfo CrowdFunDingInfo { get; set; }
    }
}
