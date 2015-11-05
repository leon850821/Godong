using GuDong.Enum.CrowdFunDingInfo;
using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class CrowdFunDingInfoController : Controller
    {
        public ICrowdFunDingInfo dal { get; set; }

        public CrowdFunDingInfoController(ICrowdFunDingInfo dal)
        {
            this.dal = dal;
        }

        public int CountCompleteNum() {
            var num = dal.CountCompleteNum();
            return num;
        }

        public PartialViewResult HomeCategoryList() {
            var data = dal.HomeCategoryList();
            return PartialView(data);
        }

        public ActionResult List(int Page = 1, int Limit =6, CrowdState Type = CrowdState.Crowding)
        {
            dal.IsOrderDesc = true;
            dal.IsThenDesc = true;
            var data = dal.List(Page, Limit, Type);
            ViewBag.CrowdState = Type;
            ViewBag.Page = Page;
            ViewBag.Count = dal.TotalCount;
            return View(data);
        }
    }
}