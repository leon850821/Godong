using GuDong.Log;
using GuDong.Unity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Filter
{
    public class ErrorFilter : FilterAttribute, IExceptionFilter
    {
       
        public ILogHelper log { get; set; }

        public ErrorFilter() {
            log = Ioc.container.Resolve<ILogHelper>();
        }

        //发生异常时会执行这段代码
        public void OnException(ExceptionContext filterContext)
        {
            //这一行告诉系统，这个异常已经处理了，不用再处理
            filterContext.ExceptionHandled = true;
            log.WebErroLog(string.Format("Url:{0}  Controller:{1}  报错内容:{2}", filterContext.HttpContext.Request.Url,filterContext.Controller, filterContext.Exception.Message));
            filterContext.HttpContext.Response.Redirect("http://www.baidu.com");
            //filterContext.HttpContext.Response.StatusCode=404;
        }
    }
}