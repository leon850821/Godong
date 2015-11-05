using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuDong.Web.Models.ModuleList;
using GuDong.Model.GuDong;

namespace GuDong.Web.Controllers
{
    public class ModuleEditController : Controller
    {

        public IModuleList dalIModuleList { get; set; }
        public IMainModule dalIMainModule { get; set; }

        public ModuleEditController(IModuleList dalIModuleList, IMainModule dalIMainModule)
        {
            this.dalIModuleList = dalIModuleList;
            this.dalIMainModule = dalIMainModule;
        }


        //
        // GET: /ModuleEdit/
        public ActionResult ModuleList()
        {
            var data = dalIModuleList.GetList();
           
            
            return View(data);
        }

        
        public ActionResult ModuleAdd(string id)
        {
            //获取主模块信息
            List<MainModule> data = dalIMainModule.GetList();
           

            if (!string.IsNullOrEmpty(id))
            {
                Guid GId = new Guid(id.ToUpper());
                var module = dalIModuleList.Find(GId);

                ViewData["MainModule"] = new SelectList(data, "Id", "ModuleName", module.MainModuleId);
                return View(module);
            }
            ViewData["MainModule"] = new SelectList(data, "Id", "ModuleName");
            return View();
        }

        [HttpPost]
        public ActionResult ModuleAdd(ModuleList model, FormCollection form)
        {
            model.MainModuleId = new Guid(form["drpmodule"].ToUpper());
            if ((model.Id == null) || model.Id == new Guid("00000000-0000-0000-0000-000000000000"))
                this.dalIModuleList.addModule(model.ModuleName, model.Controller, model.Action, model.EditController, model.EditAction, model.MainModuleId);
            else {
                model.AddDate = DateTime.Now;
                this.dalIModuleList.Update(model, model.Id);
              }

            List<MainModule> data = dalIMainModule.GetList();
            ViewData["MainModule"] = new SelectList(data, "Id", "ModuleName");
            return RedirectToAction("ModuleAdd", "ModuleEdit"); 
        }

        public ActionResult MainModuleList(int? id=1)
        {
            dalIMainModule.Page=id ?? 1 ;
            var data = dalIMainModule.GetList();
            ViewBag.Count = dalIMainModule.TotalCount;
            ViewBag.Page = dalIMainModule.Page;
            return View(data);
        }

        public ActionResult MainModuleListAdd(string id)
        {
            if(!string.IsNullOrEmpty(id))
            {
                var data = dalIMainModule.Find(new Guid(id));
                return View(data);

            }
            return View();
        }

        [HttpPost]
        public ActionResult MainModuleListAdd(MainModule model)
        {
            if ((model.Id == null) || model.Id == new Guid("00000000-0000-0000-0000-000000000000"))
            this.dalIMainModule.addMainModule(model);
            else
            {
                model.AddDate = DateTime.Now;
                this.dalIMainModule.Update(model,model.Id);
            }
            return View();
        }

        public  string   DeleteModuleList(string id)
        {
            Guid ID =new Guid(id.ToUpper());
            if (this.dalIModuleList.Delete(ID))
                return "删除成功";
            else
                return "删除失败";
        }

        public  string DeleteMainModuleList(string  id)
        {
            if(this.dalIMainModule.Delete(new Guid(id)))
                 return "删除成功";
            else
                return "删除失败";
        }

        public ActionResult PublicEditList(string EditAction, string EditController, string ModuleName)
        {
            ViewBag.ModuleName = ModuleName;
            ViewData["EditAction"] = EditAction;
            ViewData["EditController"] = EditController; 
            return View();
        }

	}
}