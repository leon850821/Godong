using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CrowdFinanceReport
    {
        public CrowdFinanceReport()
        {
            this.CrowdFinanceReportDetails = new List<CrowdFinanceReportDetail>();
        }

        public Guid Id { get; set; }
        public Guid CrowdFunDingInfo_Id { get; set; }
        public System.DateTime ReportStartDate { get; set; }
        public System.DateTime ReportEndDate { get; set; }
        public string ReportTitle { get; set; }
        public string ReportDesc { get; set; }
        public int IsProfit { get; set; }
        public int State { get; set; }
        public string AuditPerson { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public virtual CrowdFunDingInfo CrowdFunDingInfo { get; set; }
        public virtual ICollection<CrowdFinanceReportDetail> CrowdFinanceReportDetails { get; set; }
    }
}
