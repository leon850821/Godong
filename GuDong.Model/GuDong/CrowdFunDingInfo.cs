using GuDong.Enum.CrowdFunDingInfo;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CrowdFunDingInfo
    {
        public CrowdFunDingInfo()
        {
            this.CrowdBookInfoes = new List<CrowdBookInfo>();
            this.CrowdFinanceReports = new List<CrowdFinanceReport>();
            this.CrowdInvestments = new List<CrowdInvestment>();
        }

        public Guid Id { get; set; }
        public Guid Merchant_Id { get; set; }
        public string Title { get; set; }
        public string LogoUrl { get; set; }
        public string CrowdCover { get; set; }
        public string CrowdDesc { get; set; }
        public string CrowdAddress { get; set; }
        public decimal ContributionAmount { get; set; }
        public decimal ContributionShare { get; set; }
        public decimal CrowdAmount { get; set; }
        public decimal LowerUnit { get; set; }
        public int CrowdShare { get; set; }
        public int InvestmentShare { get; set; }
        public int CrowdDays { get; set; }
        public System.DateTime CrowdStartDate { get; set; }
        public int DividendsDay { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public CrowdState CrowdState { get; set; }
        public bool IsHot { get; set; }
        public int AttentionNum { get; set; }
        public string CreatePerson { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string AuditPerson { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public virtual ICollection<CrowdBookInfo> CrowdBookInfoes { get; set; }
        public virtual ICollection<CrowdFinanceReport> CrowdFinanceReports { get; set; }
        public virtual MerchantBasicInfo MerchantBasicInfo { get; set; }
        public virtual ICollection<CrowdInvestment> CrowdInvestments { get; set; }
        public virtual ICollection<CrowdBonusList> CrowdBonusList { get; set; }
    }
}
