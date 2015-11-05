using GuDong.Model.GoodJr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.IDal
{
    public interface IUserBasicInfo : IComm<B_UserBasicInfo>
    {
        /// <summary>
        /// 统计注册人数
        /// </summary>
        /// <returns></returns>
        int CountNum();

        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="UserName">用户名/手机</param>
        /// <param name="MD5Pwd">密码</param>
        /// <returns></returns>
        B_UserBasicInfo LoginVal(string UserName, string Pwd);

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="TelNo">手机号码</param>
        /// <param name="MD5Pwd">密码</param>
        /// <param name="ExtenderKey">推荐码</param>
        /// <returns></returns>
        B_UserBasicInfo Register(string TelNo, string Pwd, int ExtenderKey);
    }
}
