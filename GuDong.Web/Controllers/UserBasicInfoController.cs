using GuDong.Enum.CodeRecord;
using GuDong.IDal;
using GuDong.Model.GoodJr;
using GuDong.Tool;
using GuDong.Web.Filter;
using GuDong.Web.Models.UserBasicInfo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class UserBasicInfoController : Controller
    {
        public IUserBasicInfo dal { get; set; }
        public ICodeRecord Codedal { get; set; }

        public UserBasicInfoController(IUserBasicInfo dal, ICodeRecord Codedal)
        {
            this.dal = dal;
            this.Codedal = Codedal;
        }

        public int CountNum()
        {
            var num = dal.CountNum();
            return num;
        }

        public PartialViewResult HomeHead()
        {
            B_UserBasicInfo data = null;
            if (Cookie.Check("Gd_User", "UserId") == true)
            {
                var userid = Guid.Parse(DESC.Decrypt(Cookie.Get("Gd_User", "UserId")));
                data = dal.Find<Guid>(userid);
               
            }
            return PartialView(data);
        }

        [HttpPost]
        public ActionResult LoginVal(LoginValModel data)
        {
            if (Session["ValidateCode"] == null || data.yzCode ==null|| data.yzCode.ToUpper() != Session["ValidateCode"].ToString())
            {
                TempData["msg"] = "验证码不正确";
                return RedirectToAction("Login", "Home");
            }
            var logindata = dal.LoginVal(data.UserName, data.Pwd);
            if (logindata == null)
            {
                TempData["msg"] = dal.ErrorStr;
                return RedirectToAction("Login", "Home");
            }
            string[,] fvalue = new string[1, 2];
            fvalue[0, 0] = "UserId";
            fvalue[0, 1] = DESC.Encrypt(logindata.Id.ToString());
            bool result = Cookie.Create("Gd_User", fvalue, 0);
            if (!result)
            {
                TempData["msg"] = "Cookie禁用导致无法登录";
                return RedirectToAction("Login", "Home");
            }
            if (Request.QueryString["ReturnUrl"] != null)
            {
                return Redirect(Request.QueryString["ReturnUrl"].ToString());
            }
            return RedirectToAction("Index","Home");
        }

        public ActionResult ExitLogin() {
            string Domain = System.Configuration.ConfigurationManager.AppSettings["Domain"];
            Cookie.Del("Gd_User");
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public ActionResult Register(RegisterModel data) {
            TempData["TelNo"] = data.TelNo;
            TempData["TelCode"] = data.TelCode;
            TempData["yzCode"] = data.yzCode;
            if (Session["ValidateCode"] == null || data.yzCode == null || data.yzCode.ToUpper() != Session["ValidateCode"].ToString())
            {
                TempData["msg"] = "验证码不正确";
                TempData["yzCode"] = "";
                return RedirectToAction("Register", "Home");
            }
            var sjcode = Codedal.First(x => x.ToNumber == data.TelNo && x.Status == CodeRecordStatus.NotUse && x.Type == CodeRecordType.Register_TelNo);
            //if (sjcode == null || sjcode.Code != data.TelCode) {
            //    TempData["msg"] = "手机验证码不正确";
            //    TempData["TelCode"] ="";
            //    return RedirectToAction("Register", "Home");
            //}
            var model = dal.Register(data.TelNo, data.Pwd, data.ExtenderKey);
            if (model == null) {
                TempData["msg"] = dal.ErrorStr;
                return RedirectToAction("Register", "Home");
            }
            sjcode.Status = CodeRecordStatus.Used;
            Codedal.Update(sjcode, sjcode.Id);
            string[,] fvalue = new string[1, 2];
            fvalue[0, 0] = "UserId";
            fvalue[0, 1] = DESC.Encrypt(model.Id.ToString());
            bool result = Cookie.Create("Gd_User", fvalue, 0);
            return RedirectToAction("Index", "Home");
        }
    }
}