using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuDong.Web.Models.UserBasicInfo
{
    public class RegisterModel
    {
        public string TelNo { get; set; }
        public string TelCode { get; set; }
        public string Pwd { get; set; }
        public string yzCode { get; set; }
        public int ExtenderKey { get; set; }
    }
}