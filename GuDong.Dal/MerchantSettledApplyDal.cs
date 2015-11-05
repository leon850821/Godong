using GuDong.EF.GuDong;
using GuDong.Enum.Comm;
using GuDong.Enum.MerchantSettledApply;
using GuDong.IDal;
using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Dal
{
    public class MerchantSettledApplyDal : Comm<MerchantSettledApply>, IMerchantSettledApply
    {
        public MerchantSettledApply AddApply(string TelNo, string RealName, SexType Sex)
        {
            if (ct.Set<MerchantSettledApply>().Count(x => x.TelNo == TelNo && x.ApplyState == ApplyState.NotAcceptance) > 0)
            {
                this.ErrorStr = "此手机号码已申请";
                return null;
            }
            if (string.IsNullOrEmpty(RealName)) {
                this.ErrorStr = "姓名不能为空";
                return null;
            }
            var add=new MerchantSettledApply() { 
                Id=Guid.NewGuid(),
                ApplyDate=DateTime.Now,
                ApplyState = ApplyState.NotAcceptance,
                RealName=RealName,
                Sex = Sex,
                TelNo=TelNo
            };
            ct.Set<MerchantSettledApply>().Add(add);
            ct.SaveChanges();
            return add;
        }
    }
}
