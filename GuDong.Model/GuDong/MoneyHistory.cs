using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class MoneyHistory
    {
        public Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public int Type { get; set; }
        public decimal RewardMoney { get; set; }
        public decimal Amount { get; set; }
        public string Memo { get; set; }
        public System.DateTime AddDate { get; set; }
    }
}
