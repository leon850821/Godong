using GuDong.IDal;
using GuDong.Log;
using GuDong.Tool;
using GuDong.Web.Filter;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login() {
            if (Cookie.Check("Gd_User", "UserId") ==true)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult ValidateCode() {
            var vCode = new ValidateCode();
            byte[] bytes = vCode.CreateCodeImg();
            Session["ValidateCode"] = vCode.RandomCode.ToUpper();
            return File(bytes, @"image/jpeg");
        }

        public ActionResult Register() {
            return View();
        }

        public ActionResult MallJoin() {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}