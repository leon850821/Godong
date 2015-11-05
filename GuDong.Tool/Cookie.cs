using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GuDong.Tool
{
    /// <summary>
    /// 操作Cookie的方法集
    /// </summary>
    public static class Cookie
    {
        public static string Domain = ConfigurationManager.AppSettings["Domain"];
 
        /// <summary>
        /// 创建Cookie的方法（返回True=创建成功,False=创建失败）
        /// </summary>
        /// <param name="Domain">绑定Cookie到域名，为空时，为当前域名。</param>
        /// <param name="CookieName">Cookie集合名称</param>
        /// <param name="Fvalue">Cookie字段名及值的数组（Fvalue[i,0]=名称；Fvalue[i,1]=值）</param>
        /// <param name="Exmin">过期时间，以天为单位，为0时，关闭页面就失效。</param>
        /// <returns>返回True=创建成功,False=创建失败</returns>
        public static bool Create(string CookieName, string[,] Fvalue, int Exmin)
        {
            bool _createCookie = true;

            try
            {

                //创建用户COOKIE状态....
                HttpCookie MyUserCookie = new HttpCookie(CookieName);

                for (int i = 0; i < Fvalue.Length / 2; i++)
                {
                    MyUserCookie.Values[Fvalue[i, 0]] = Fvalue[i, 1];
                }
                if (!string.IsNullOrEmpty(Domain))
                {
                    MyUserCookie.Domain = Domain;
                }

                if (Exmin > 0)
                {
                    MyUserCookie.Expires = DateTime.Now.AddDays(Exmin);
                }

                System.Web.HttpContext.Current.Response.Cookies.Add(MyUserCookie);
            }
            catch
            {
                _createCookie = false;
            }

            return _createCookie;
        }

        /// <summary>
        /// 删除Cookie的方法（返回True=删除成功,False=删除失败）
        /// </summary>
        /// <param name="Domain">绑定Cookie到域名，为空时，为当前域名。</param>
        /// <param name="CookieName">Cookie集合名称</param>
        /// <returns>返回True=删除成功,False=删除失败</returns>
        public static bool Del(string CookieName)
        {
            bool _delcookie = true;

            try
            {
                HttpCookie MyUserCookie = new HttpCookie(CookieName);

                if (!string.IsNullOrEmpty(Domain))
                {
                    MyUserCookie.Domain = Domain;
                }

                MyUserCookie.Expires = DateTime.Now.AddYears(-1);
                System.Web.HttpContext.Current.Response.Cookies.Add(MyUserCookie);
            }
            catch
            {
                _delcookie = false;
            }

            return _delcookie;
        }

        /// <summary>
        /// 检查Cookie是否存在（返回True=存在,False=不存在）
        /// </summary>
        /// <param name="CookieName">Cookie集合的名称</param>
        /// <param name="CookieKey">Cookie集合的字段名</param>
        /// <returns>返回True=存在,False=不存在</returns>
        public static bool Check(string CookieName, string CookieKey)
        {
            bool _checkcookie = true;
            try
            {
                string _temp_cookie;
                if (HttpContext.Current.Request.Cookies[CookieName] == null)
                {
                    _checkcookie = false;
                }
                else
                {
                    _temp_cookie = HttpContext.Current.Request.Cookies[CookieName].Values[CookieKey];
                    if (string.IsNullOrEmpty(_temp_cookie))
                    {
                        _checkcookie = false;
                    }
                }
            }
            catch
            {
                _checkcookie = false;
            }

            return _checkcookie;

        }

        /// <summary>
        /// 得到Cookie集合的Cookie的方法，返回null=无任何cookie,其它为cookie的值
        /// </summary>
        /// <param name="CookieName">Cookie集合的名称</param>
        /// <param name="CookieKey">Cookie集合的字段名</param>
        /// <returns>返回null=无任何cookie,其它为cookie的值</returns>
        public static string Get(string CookieName, string CookieKey)
        {
            string _getcookie = null;
            try
            {
                string _temp_cookie;
                if (HttpContext.Current.Request.Cookies[CookieName] == null)
                {
                    _getcookie = null;
                }
                else
                {
                    _temp_cookie = HttpContext.Current.Request.Cookies[CookieName].Values[CookieKey];
                    if (!string.IsNullOrEmpty(_temp_cookie))
                    {
                        _getcookie = HttpContext.Current.Request.Cookies[CookieName].Values[CookieKey];
                    }
                }
            }
            catch
            {
                _getcookie = null;
            }

            return _getcookie;
        }
    }
}
