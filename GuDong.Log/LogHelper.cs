using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.xml", Watch = true)]
namespace GuDong.Log
{
    public class LogHelper:ILogHelper
    {
        public void WebErroLog(string msg) {
            ILog log = log4net.LogManager.GetLogger(AppenderEnum.WebErroLog.ToString());
            log.Error(msg);
        }
    }
}
