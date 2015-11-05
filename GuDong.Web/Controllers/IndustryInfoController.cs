using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class IndustryInfoController : Controller
    {
        public IIndustryInfo dal { get; set; }

        public IndustryInfoController(IIndustryInfo dal) {
            this.dal = dal;
        }

        public PartialViewResult InvolveIndustry() {
            var data = dal.InvolveIndustry();
            return PartialView(data);
        }
    }
}