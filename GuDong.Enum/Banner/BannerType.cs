using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.Banner
{
    public  enum BannerType
    {
        /// <summary>
        /// 首页头部
        /// </summary>
        [Description("首页头部")]
        HomeHead = 1,
        /// <summary>
        /// 首页中部
        /// </summary>
        [Description("首页中部")]
        HomeMid = 2,
    }
}
