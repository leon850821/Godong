using System;
using System.Collections.Generic;


namespace GuDong.Model.GoodJr
{
    public partial class B_UserBankInfoLog
    {

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string BankNo { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string OpenName { get; set; }
        public string RealName { get; set; }
        public DateTime? AddDate { get; set; }
        public int? type { get; set; }
        public string UpdateUser { get; set; }
        public string CardNo { get; set; }
        public virtual B_UserBasicInfo B_UserBasicInfo { get;set;}
    }
}
