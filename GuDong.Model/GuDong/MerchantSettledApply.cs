using GuDong.Enum.Comm;
using GuDong.Enum.MerchantSettledApply;
using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class MerchantSettledApply
    {
        public Guid Id { get; set; }
        public string TelNo { get; set; }
        public string RealName { get; set; }
        public SexType Sex { get; set; }
        public string ApplyDesc { get; set; }
        public ApplyState ApplyState { get; set; }
        public System.DateTime ApplyDate { get; set; }
        public string AcceptancePerson { get; set; }
        public Nullable<DateTime> AcceptanceDate { get; set; }
    }
}
