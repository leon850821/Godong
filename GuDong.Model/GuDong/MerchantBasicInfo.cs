using GuDong.Enum.Merchant;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class MerchantBasicInfo
    {
        public MerchantBasicInfo()
        {
            this.CrowdFunDingInfoes = new List<CrowdFunDingInfo>();
            this.DiscountInfoes = new List<DiscountInfo>();
        }

        public Guid Id { get; set; }
        public System.Guid User_Id { get; set; }
        public string MerchantName { get; set; }
        public string LegalName { get; set; }
        public Nullable<Guid> IndustryInfo_Id { get; set; }
        public Nullable<Guid> IndustryInfo_ChildId { get; set; }
        public string RegistrationNo { get; set; }
        public string OrganizationCode { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> RegisteredCapital { get; set; }
        public string EnterpriseDescription { get; set; }
        public string BusinessDescription { get; set; }
        public Nullable<System.DateTime> OpeningDate { get; set; }
        public string RegistrationAuthority { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public string BusinessRange { get; set; }
        public string LogoUrl { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobilePhone { get; set; }
        public string ContactFax { get; set; }
        public string ContactAddress { get; set; }
        public string ContactZip { get; set; }
        public Nullable<int> BranchNum { get; set; }
        public string LegalCredentialsNumImg { get; set; }
        public string LegalCreditReportImg { get; set; }
        public string BusinessLicenseImg { get; set; }
        public string TaxRegistrationImg { get; set; }
        public string OrganizationCodeImg { get; set; }
        public string CompanyImgImg { get; set; }
        public string LeaseContractImg { get; set; }
        public string TradeLicenseImg { get; set; }
        public MerchantState Status { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual ICollection<CrowdFunDingInfo> CrowdFunDingInfoes { get; set; }
        public virtual ICollection<DiscountInfo> DiscountInfoes { get; set; }
        public virtual IndustryInfo IndustryInfo { get; set; }
        public virtual IndustryInfo IndustryInfo1 { get; set; }
    }
}
