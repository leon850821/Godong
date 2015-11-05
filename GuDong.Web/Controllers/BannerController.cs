using GuDong.Enum.Banner;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GuDong.Tool;
using Webdiyer.WebControls.Mvc;

namespace GuDong.Web.Controllers
{
    public class BannerController : Controller
    {
        public IBanner dal { get; set; }

        public BannerController(IBanner dal) {
            this.dal = dal;
        }

        public PartialViewResult HomeHeadBanner()
        {
            //var data = dal.Find<int, int>(x => x.Type == BannerType.HomeHead, x => x.Sort, x => x.Sort);
            //return PartialView(data);
            var data = dal.Find< int>(x => x.Type == BannerType.HomeHead, x => x.Sort);
            return PartialView(data);
        }

        public PartialViewResult HomeMidBanner() {
            var data = dal.Find<int, int>(x => x.Type == BannerType.HomeMid, x => x.Sort, x => x.Sort).FirstOrDefault();
            return PartialView(data);
        }

        public PartialViewResult BannerEditList( string search,  int? id = 1)
        {
            dal.Page = id ?? 1;

            var data = string.IsNullOrEmpty(search) ? dal.Find<int>(x => 1 == 1, x => x.Sort) : dal.Find<int>(x => x.Title.Contains(search), x => x.Sort);
            PagedList<Banner> mPage = data.AsQueryable().ToPagedList(dal.Page,10);
            mPage.TotalItemCount = dal.TotalCount;
            mPage.CurrentPageIndex=(int)(id ?? 1);
            ViewBag.search = search;
            ViewBag.Page = dal.Page;
            ViewBag.Count = dal.TotalCount;
            return PartialView(mPage);
        }


        public ViewResult BannerEditListAdd(string  id)
        {
           
          var bannerTypeList = EnumHelper.GetList(typeof(BannerType));
          if (!string.IsNullOrEmpty(id))
          {
              var data = dal.Find(new Guid(id));
              ViewData["BannerType"] = new SelectList(bannerTypeList, "Value", "Key"); 
              return View(data);
          }
   
            ViewData["BannerType"] = new SelectList(bannerTypeList, "Value", "Key");
            return View();
        }

        [HttpPost]
        public ViewResult BannerEditListAdd(Banner banner)
        {
           
            banner.AddTime = DateTime.Now;
            if ((banner.Id == null) || banner.Id == new Guid("00000000-0000-0000-0000-000000000000"))
            {
                banner.Id = Guid.NewGuid();
                dal.Add(banner);           
            }
            else
            {
                dal.Update(banner,banner.Id);
            }
            var bannerTypeList = EnumHelper.GetList(typeof(BannerType));
            ViewData["BannerType"] = new SelectList(bannerTypeList, "Value", "Key");
            return View(); 
        }
      public string DeleteBannerList(string  id)
        {
          if(dal.Delete(new Guid(id)))
                 return "删除成功";
              else
                  return "删除失败";


        }
         
    }
}
 