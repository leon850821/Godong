using GuDong.Enum.Comm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuDong.Web.Models.MerchantSettledApply
{
    public class AddApplyModel
    {
        public string TelNo { get; set; }
        public string TelCode { get; set; }
        public string RealName { get; set; }
        public SexType Sex { get; set; }
        public string yzCode { get; set; }
    }
}