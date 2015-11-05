using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Tool
{
   public  class Encryption
    {
        // <summary>
        /// MD5加密
        /// </summary>
        /// <param name="enstring">加密的内容</param>
        /// <returns>MD5加密结果</returns>
        public static string MD5(string enstring)
        {
            enstring = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("gu" + enstring + "de", "sha1");
            enstring = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(enstring, "MD5");
            return enstring;
        }
    }
}
