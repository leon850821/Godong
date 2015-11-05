using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class CrowdBonusListController : Controller
    {
        public ICrowdBonusList dal { get; set; }

        public CrowdBonusListController(ICrowdBonusList dal)
        {
            this.dal = dal;
        }

        public decimal CountBonusAmount() {
            var num = dal.CountBonusAmount();
            return num==null?0: num.Value;
        }
    }
}