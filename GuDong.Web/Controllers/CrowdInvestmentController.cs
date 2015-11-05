using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class CrowdInvestmentController : Controller
    {
       public ICrowdInvestment dal { get; set; }
       public IUserBasicInfo userdal { get; set; }

       public CrowdInvestmentController(ICrowdInvestment dal, IUserBasicInfo userdal)
        {
            this.dal = dal;
            this.userdal = userdal;
        }

       public PartialViewResult GetDateDescTop5()
        {
            var data = dal.GetDateDescTop5();
           var userids=data.Select(x=>x.User_Id).Distinct();
           ViewBag.userdata = userdal.Find(x => userids.Contains(x.Id),x=>x.Id);
           return PartialView(data);
        }
    }
}