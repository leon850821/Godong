using GuDong.Enum.CodeRecord;
using GuDong.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuDong.Web.Controllers
{
    public class CodeRecordController : Controller
    {
        public ICodeRecord dal { get; set; }
        public IUserBasicInfo Userdal { get; set; }

        public CodeRecordController(ICodeRecord dal, IUserBasicInfo Userdal)
        {
            this.dal = dal;
            this.Userdal = Userdal;
        }

        public string SendRegisterSmsCode(string TelNo)
        {
            if (Userdal.First(x => x.TelNo == TelNo) != null) {
                return "此手机已注册";
            }
            if (dal.SendSmsCode(TelNo, CodeRecordType.Register_TelNo))
            {
                return "发送成功";
            }
            else {
                return dal.ErrorStr;
            }
           
        }

        public string SendMallJoinSmsCode(string TelNo)
        {
            if (Userdal.First(x => x.TelNo == TelNo) != null)
            {
                return "此手机已注册,用户可以登录个人中心进行申请";
            }
            if (dal.SendSmsCode(TelNo, CodeRecordType.GdMallJoin))
            {
                return "发送成功";
            }
            else
            {
                return dal.ErrorStr;
            }

        }
    }
}