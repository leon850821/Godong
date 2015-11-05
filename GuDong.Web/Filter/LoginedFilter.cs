using GuDong.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Filter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class LoginedFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ReturnUrl = filterContext.HttpContext.Request.Url.ToString();
            if (Cookie.Check("Gd_User", "UserId") == false)
            {
                filterContext.Result = new EmptyResult();
                filterContext.HttpContext.Response.Redirect("../Home/Login?ReturnUrl=" + ReturnUrl);
            }
        }
    }
}