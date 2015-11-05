using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace GuDong.IDal
{
    public  interface  IModuleList:IComm<ModuleList>
    {
          List<ModuleList> GetList();

          ModuleList addModule(string moduleName, string controller, string action, string EditController, string Editaction, Guid MainModuleId);
       
    }
}
