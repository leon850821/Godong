using GuDong.EF.GuDong;
using GuDong.Enum.CodeRecord;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using GuDong.Tool.SMS;

namespace GuDong.Dal
{
    public class CodeRecordDal : Comm<CodeRecord>, ICodeRecord
    {
        public SendSms sms { get; set; }

        public CodeRecordDal()
        {
            this.sms = new SendSms();
        }

        public bool SendSmsCode(string ToNumber, CodeRecordType Type)
        {
            if (!Regex.IsMatch(ToNumber, @"^1[3|5|4|7|8][0-9]\d{8}$"))
            {
                this.ErrorStr = "请输入正确手机号码";
                return false;
            }
           var codedata = ct.Set<CodeRecord>().FirstOrDefault(x => x.ToNumber == ToNumber && x.Type == Type && x.Status==CodeRecordStatus.NotUse);
           if (codedata!=null && codedata.AddDate.AddMinutes(1.5) > DateTime.Now)
           {
               this.ErrorStr = "90分钟内不能重复发送";
               return false;
           }
           Random random = new Random();
           var ran = random.Next(100000, 1000000).ToString();
           if (codedata == null)
           {
               ct.Set<CodeRecord>().Add(new CodeRecord() { 
                   Id=Guid.NewGuid(),
                   AddDate=DateTime.Now,
                   Code = ran,
                   Status = CodeRecordStatus.NotUse,
                   ToNumber=ToNumber,
                   Type = Type
               });
           }
           else {
               codedata.AddDate = DateTime.Now;
               codedata.Code = ran;
           }
            ct.SaveChanges();
            if (sms.Send(ToNumber, ran, "1.5"))
            {
                return true;
            }
            else
            {
                this.ErrorStr = sms.ErrorMsg;
                return false;
            }
        }
    }
}
