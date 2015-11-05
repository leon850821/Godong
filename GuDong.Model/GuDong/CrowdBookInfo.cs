using System;
using System.Collections.Generic;

namespace GuDong.Model.GuDong
{
    public partial class CrowdBookInfo
    {
        public Guid Id { get; set; }
        public Guid CrowdFunDingInfo_Id { get; set; }
        public System.Guid User_Id { get; set; }
        public int BookShare { get; set; }
        public decimal BookAmount { get; set; }
        public System.DateTime BookDate { get; set; }
        public virtual CrowdFunDingInfo CrowdFunDingInfo { get; set; }
    }
}
