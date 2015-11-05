using GuDong.Enum;
using GuDong.Enum.AccountRechare;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class AccountRechare
    {
        public Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public AccountRechareType Type { get; set; }
        public AccountRechareStatus Status { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string HandlerUser { get; set; }
        public decimal Amount { get; set; }
        public decimal HandCharge { get; set; }
        public string MediumOrderNo { get; set; }
        public string BankCode { get; set; }
        public string Memo { get; set; }
        public decimal Realhandfee { get; set; }
    }
}
