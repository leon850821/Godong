using GuDong.Enum.CodeRecord;
using GuDong.IDal;
using GuDong.Web.Models.MerchantSettledApply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class MerchantSettledApplyController : Controller
    {
        public IMerchantSettledApply dal { get; set; }
        public ICodeRecord Codedal { get; set; }

        public MerchantSettledApplyController(IMerchantSettledApply dal, ICodeRecord Codedal)
        {
            this.dal = dal;
            this.Codedal = Codedal;
        }

        [HttpPost]
        public ActionResult AddApply(AddApplyModel data) {
            TempData["TelNo"] = data.TelNo;
            TempData["TelCode"] = data.TelCode;
            TempData["RealName"] = data.RealName;
            TempData["Sex"] = data.Sex;
            if (Session["ValidateCode"] == null || data.yzCode == null || data.yzCode.ToUpper() != Session["ValidateCode"].ToString())
            {
                TempData["msg"] = "验证码不正确";
                TempData["yzCode"] = "";
                return RedirectToAction("MallJoin", "Home");
            }
            var sjcode = Codedal.First(x => x.ToNumber == data.TelNo && x.Status == CodeRecordStatus.NotUse && x.Type == CodeRecordType.GdMallJoin);
            if (sjcode == null || sjcode.Code != data.TelCode)
            {
                TempData["msg"] = "手机验证码不正确";
                TempData["TelCode"] = "";
                return RedirectToAction("MallJoin", "Home");
            }
            var model = dal.AddApply(data.TelNo, data.RealName, data.Sex);
            if (model == null) {
                TempData["msg"] = dal.ErrorStr;
                return RedirectToAction("MallJoin", "Home");
            }
            return View(model);
        }
    }
}