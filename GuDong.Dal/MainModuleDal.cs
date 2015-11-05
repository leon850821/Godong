using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuDong.Model.GuDong;
using GuDong.IDal;
using System.Data.Entity.Infrastructure;

namespace GuDong.Dal
{
    class MainModuleDal : Comm<MainModule>, IMainModule
    {
        public List<MainModule> GetList()
        {
            return ct.Set<MainModule>().OrderByDescending(x => x.AddDate).ToList();
        }

        public MainModule addMainModule(MainModule mainModule)
        {
            var add = new MainModule();
            try
            {
                add.Id = Guid.NewGuid();
                add.ModuleName = mainModule.ModuleName;
                add.Controller = mainModule.Controller;
                add.EditController = mainModule.EditController;
                add.AddDate = DateTime.Now;
                ct.Set<MainModule>().Add(add);
                ct.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return add;
        }
      
    }
}
