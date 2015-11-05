using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CrowdFinanceReportDetail
    {
        public Guid Id { get; set; }
        public Guid CrowdFinanceReport_Id { get; set; }
        public int DetailType { get; set; }
        public string DetailName { get; set; }
        public int DetailNum { get; set; }
        public decimal DetailAmount { get; set; }
        public virtual CrowdFinanceReport CrowdFinanceReport { get; set; }
    }
}
