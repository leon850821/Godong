using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Enum.CodeRecord
{
    public enum CodeRecordType
    {
        /// <summary>
        /// 手机验证
        /// </summary>
        [Description("手机绑定")]
        SJYZ = 1001,
        /// <summary>
        /// 手机重置
        /// </summary>
        [Description("手机重置")]
        SJCZ = 1002,
        /// <summary>
        /// 手机找回密码
        /// </summary>
        [Description("手机找回密码")]
        SJZHMM = 1003,
        /// <summary>
        /// 提现短信接收
        /// </summary>
        [Description("提现短信接收")]
        SJTXDXJS = 1004,
        /// <summary>
        /// 手机重置邮箱
        /// </summary>
        [Description("手机重置邮箱")]
        SJCZYX = 1005,
        /// <summary>
        /// 手机重置支付密码
        /// </summary>
        [Description("手机重置支付密码")]
        SJCZZFMM = 1006,
        /// <summary>
        /// 手机绑定银行卡号
        /// </summary>
        [Description("手机绑定银行卡号")]
        SJBDYHKH = 1007,
        /// <summary>
        /// 贷款申请
        /// </summary>
        [Description("贷款申请")]
        SJSQDK = 1008,
        /// <summary>
        /// 手机注册
        /// </summary>
        [Description("手机注册")]
        Register_TelNo = 1009,
        /// <summary>
        /// 提现申请
        /// </summary>
        [Description("提现申请")]
        Withdraw = 1010,
        /// <summary>
        /// 邮箱验证
        /// </summary>
        [Description("邮箱验证")]
        YXYZ = 2001,
        /// <summary>
        /// 邮箱重置手机
        /// </summary>
        [Description("邮箱重置手机")]
        YXCZSJ = 2002,
        /// <summary>
        /// 邮箱重置
        /// </summary>
        [Description("邮箱重置")]
        YXCZ = 2003,
        /// <summary>
        /// 邮箱注册
        /// </summary>
        [Description("邮箱注册")]
        Register_Mail = 2004,
        /// <summary>
        /// 咕咚商家入驻
        /// </summary>
        [Description("咕咚商家入驻")]
        GdMallJoin = 3001,
    }
}
