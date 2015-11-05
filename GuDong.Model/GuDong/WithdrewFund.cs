using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class WithdrewFund
    {
        public Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public Nullable<System.Guid> AuditorId { get; set; }
        public Nullable<decimal> HandingCharge { get; set; }
        public Nullable<decimal> ActualWithdrawDeposit { get; set; }
        public int type { get; set; }
        public string WithdrawNo { get; set; }
        public string Memo { get; set; }
        public string BankNo { get; set; }
        public string RealName { get; set; }
        public int BankType { get; set; }
        public string otherBankName { get; set; }
        public string OpenBank { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public Nullable<System.DateTime> AuditingDate { get; set; }
        public Nullable<decimal> RealHandFee { get; set; }
    }
}
