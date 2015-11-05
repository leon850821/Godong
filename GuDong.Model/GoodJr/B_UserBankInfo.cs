using System;
using System.Collections.Generic;

namespace GuDong.Model.GoodJr
{

    public partial class B_UserBankInfo
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string BankAccountNo { get; set; }
        public int? BankType { get; set; }
        public string BankProvice { get; set; }
        public string BankCity { get; set; }
        public string OpenBankName { get; set; }
        public string otherBankName { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime? AddData { get; set; }
        public int? Status { get; set; }
        public virtual B_UserBasicInfo B_UserBasicInfo { get; set; }
    }
}
