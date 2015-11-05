using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuDong.IDal
{
    public  interface IMainModule:IComm<MainModule>
    {
        List<MainModule> GetList();

        MainModule addMainModule(MainModule mainModule);
    }
}
