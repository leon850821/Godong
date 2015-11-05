using GuDong.Enum.User;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GoodJr
{

    public partial class B_UserBasicInfo
    {
        public B_UserBasicInfo()
        {
            B_UserBankInfo = new HashSet<B_UserBankInfo>();
            B_UserBankInfoLog = new HashSet<B_UserBankInfoLog>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public string PayPwd { get; set; }
        public UserType UserType { get; set; }
        public string RealName { get; set; }
        public string CredentialsNum { get; set; }
        public int? CredentialsType { get; set; }
        public UserLevelType Level { get; set; }
        public DateTime? LevelBeginDate { get; set; }
        public DateTime? LevelEndDate { get; set; }
        public string HeadImage { get; set; }
        public string Sex { get; set; }
        public UserStatus Status { get; set; }
        public int ExtendKey { get; set; }
        public int? ExtenderKey { get; set; }
        public bool? ExtendUsed { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Birthday { get; set; }
        public int? PwdErrorNum { get; set; }
        public DateTime? PwdErrorTime { get; set; }
        public string SealPersonageKey { get; set; }
        public string SealCompanyKey { get; set; }
        public decimal CreditGrantingAmount { get; set; }
        public decimal UsedCreditGrantingAmount { get; set; }
        public DateTime? PerformanceStartTime { get; set; }
        public virtual ICollection<B_UserBankInfo> B_UserBankInfo { get; set; }
        public virtual ICollection<B_UserBankInfoLog> B_UserBankInfoLog { get; set; }
    }
}
