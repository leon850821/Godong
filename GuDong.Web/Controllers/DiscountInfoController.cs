using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class DiscountInfoController : Controller
    {
        public IDiscountInfo dal { get; set; }

        public DiscountInfoController(IDiscountInfo dal) {
            this.dal = dal;
        }

        public PartialViewResult HomeList() {
            dal.Page = 1;
            dal.Limit = 4;
            var data = dal.Find<int,DateTime>(x => x.EndDate > DateTime.Now, x => x.Sort, x => x.CreateDate);
            return PartialView(data);
        }
    }
}