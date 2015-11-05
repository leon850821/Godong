using GuDong.Enum.NewInfo;
using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class NewInfoController : Controller
    {
        public INewInfo dal { get; set; }

        public NewInfoController(INewInfo dal) {
            this.dal = dal;
        }

        public PartialViewResult HomeHeadNew()
        {
            var data = dal.Find<bool?,bool?>(x => x.Type == NewType.HomeHead, x => x.IsTop, x => x.IsTop);
            return PartialView(data);
        }
    }
}