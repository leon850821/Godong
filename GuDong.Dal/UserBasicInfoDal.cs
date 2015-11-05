using GuDong.EF.GoodJr;
using GuDong.Enum.User;
using GuDong.IDal;
using GuDong.Model.GoodJr;
using GuDong.Tool;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class UserBasicInfoDal : GoodFinancialComm<B_UserBasicInfo>, IUserBasicInfo
    {
        public int CountNum()
        {
            return ct.Set<B_UserBasicInfo>().Count();
        }

        public B_UserBasicInfo LoginVal(string UserName, string Pwd)
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Pwd))
            {
                this.ErrorStr = "用户名或者密码不能为空";
                return null;
            }
            string MD5Pwd = Encryption.MD5(Pwd);
            var data = ct.Set<B_UserBasicInfo>().FirstOrDefault(x =>( ( x.UserName.Equals(UserName) || x.TelNo.Equals(UserName) ) && (x.Pwd == MD5Pwd) ) );
            if (data == null)
            {
                this.ErrorStr = "用户名或者密码有误";
                return null;
            }
            return data;
        }

        public B_UserBasicInfo Register(string TelNo, string Pwd, int ExtenderKey)
        {
            if (!Regex.IsMatch(TelNo, @"^1[3|5|4|7|8][0-9]\d{8}$"))
            {
                this.ErrorStr = "手机格式有误";
                return null;
            }
            if (string.IsNullOrWhiteSpace(Pwd) || Pwd.Length < 6 || Pwd.Length > 20)
            {
                this.ErrorStr = "密码格式有误";
                return null;
            }
            if (ct.Set<B_UserBasicInfo>().Count(x => x.TelNo == TelNo) > 0) {
                this.ErrorStr = "此手机已注册";
                return null;
            }
            if (ExtenderKey>0 && ct.Set<B_UserBasicInfo>().Count(x => x.ExtenderKey == ExtenderKey) == 0)
            {
                this.ErrorStr = "推荐码不存在";
                return null;
            }
            int num = 3;
            var add = new B_UserBasicInfo();
            while (num > 0) {
                try { 
                    add.Id = Guid.NewGuid();
                    add.UserName = TelNo;
                    add.NickName = TelNo;
                    add.Pwd = Encryption.MD5(Pwd);
                    add.PayPwd = Encryption.MD5(Pwd);
                    add.TelNo = TelNo;
                    add.UserType = UserType.GuDongUser;
                    add.Status = UserStatus.Start;
                    add.ExtenderKey = ExtenderKey;
                   
                    add.ExtendKey = ((ct.Set<B_UserBasicInfo>().FirstOrDefault() == null) ? 1 : (ct.Set<B_UserBasicInfo>().Max(x => x.ExtendKey) + 1));
                    add.ExtendUsed = true;
                    add.LastLoginDate = DateTime.Now;
                    add.CreateDate = DateTime.Now;
                    add.CreditGrantingAmount = 0;
                    add.UsedCreditGrantingAmount = 0;
                    add.PerformanceStartTime = DateTime.Now;
                    ct.Entry<B_UserBasicInfo>(add).State = EntityState.Added;
                    ct.SaveChanges();
                    return add;
                }
                catch (DbUpdateConcurrencyException){
                    num -= 1;
                }
            }
            this.ErrorStr = "注册失败";
            return null;
        }
    }
}
