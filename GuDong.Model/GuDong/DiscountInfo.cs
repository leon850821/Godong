using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class DiscountInfo
    {
        public Guid Id { get; set; }
        public Guid Merchant_Id { get; set; }
        public string Title { get; set; }
        public string LogoUrl { get; set; }
        public string DiscountDesc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Sort { get; set; }
        public string CreatePerson { get; set; }
        public System.DateTime CreateDate { get; set; }
        public virtual MerchantBasicInfo MerchantBasicInfo { get; set; }
    }
}
