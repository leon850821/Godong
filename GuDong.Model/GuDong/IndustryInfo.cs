using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class IndustryInfo
    {
        public IndustryInfo()
        {
            this.IndustryInfo1 = new List<IndustryInfo>();
            this.MerchantBasicInfoes = new List<MerchantBasicInfo>();
            this.MerchantBasicInfoes1 = new List<MerchantBasicInfo>();
        }

        public Guid Id { get; set; }
        public string IndustryName { get; set; }
        public string IndustryIco { get; set; }
        public Nullable<Guid> Industry_Pid { get; set; }
        public virtual ICollection<IndustryInfo> IndustryInfo1 { get; set; }
        public virtual IndustryInfo IndustryInfo2 { get; set; }
        public virtual ICollection<MerchantBasicInfo> MerchantBasicInfoes { get; set; }
        public virtual ICollection<MerchantBasicInfo> MerchantBasicInfoes1 { get; set; }
    }
}
