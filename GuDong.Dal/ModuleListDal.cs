using GuDong.EF.GuDong;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuDong.Model.GoodJr;
using GuDong.Enum.CrowdFunDingInfo;
using System.Data.Entity.Infrastructure;

namespace GuDong.Dal
{
    public class ModuleListDal : Comm<ModuleList>,IModuleList
    {

        public List<ModuleList> GetList()
        {
            return ct.Set<ModuleList>().Include("MainModule").OrderByDescending(x => x.AddDate).ToList();
        }

        public ModuleList addModule(string moduleName, string controller, string action, string EditController, string Editaction, Guid MainModuleId)
        {
              var add = new ModuleList();
              try
              {
                  add.Id = Guid.NewGuid();
                  add.ModuleName = moduleName;
                  add.Controller = controller;
                  add.Action = action;
                  add.EditController = EditController;
                  add.EditAction = Editaction;
                  add.AddDate = DateTime.Now;
                  add.MainModuleId = MainModuleId;
                  ct.Set<ModuleList>().Add(add);
                  ct.SaveChanges();
              }
              catch (DbUpdateConcurrencyException)
              {
              }
              return add;                   
        }
    }
}
