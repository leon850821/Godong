using GuDong.Model.GoodJr;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.EF.GoodJr.Mapping
{
   public class B_UserBasicInfoMap : EntityTypeConfiguration<B_UserBasicInfo>
    {
       public B_UserBasicInfoMap() {

           this.HasKey(t => t.Id);

           this.Property(t => t.UserName)
                .HasMaxLength(50);

           this.Property(t => t.NickName)
                .HasMaxLength(100);

           this.Property(t => t.TelNo)
                .HasMaxLength(30);

           this.Property(t => t.Email)
                .HasMaxLength(100);

           this.Property(t => t.Pwd)
                .HasMaxLength(100);

           this.Property(t => t.PayPwd)
                .HasMaxLength(100);

           this.Property(t => t.RealName)
                .HasMaxLength(100);

           this.Property(t => t.CredentialsNum)
                .HasMaxLength(100);

           this.Property(t => t.HeadImage)
                .HasMaxLength(250);

           this.Property(t => t.Sex)
                .HasMaxLength(2);

           this.Property(t => t.SealPersonageKey)
                .HasMaxLength(100);

           this.Property(t => t.SealCompanyKey)
                .HasMaxLength(100);

           this.ToTable("B_UserBasicInfo");
           this.Property(t => t.Id).HasColumnName("Id");
           this.Property(t => t.UserName).HasColumnName("UserName");
           this.Property(t => t.NickName).HasColumnName("NickName");
           this.Property(t => t.TelNo).HasColumnName("TelNo");
           this.Property(t => t.Email).HasColumnName("Email");
           this.Property(t => t.Pwd).HasColumnName("Pwd");
           this.Property(t => t.PayPwd).HasColumnName("PayPwd");
           this.Property(t => t.UserType).HasColumnName("UserType");
           this.Property(t => t.RealName).HasColumnName("RealName");
           this.Property(t => t.CredentialsNum).HasColumnName("CredentialsNum");
           this.Property(t => t.CredentialsType).HasColumnName("CredentialsType");
           this.Property(t => t.Level).HasColumnName("Level");
           this.Property(t => t.LevelBeginDate).HasColumnName("LevelBeginDate");
           this.Property(t => t.LevelEndDate).HasColumnName("LevelEndDate");
           this.Property(t => t.HeadImage).HasColumnName("HeadImage");
           this.Property(t => t.Sex).HasColumnName("Sex");
           this.Property(t => t.Status).HasColumnName("Status");
           this.Property(t => t.ExtendKey).HasColumnName("ExtendKey");
           this.Property(t => t.ExtenderKey).HasColumnName("ExtenderKey");
           this.Property(t => t.ExtendUsed).HasColumnName("ExtendUsed");
           this.Property(t => t.LastLoginDate).HasColumnName("LastLoginDate");
           this.Property(t => t.CreateDate).HasColumnName("CreateDate");
           this.Property(t => t.Birthday).HasColumnName("Birthday");
           this.Property(t => t.PwdErrorNum).HasColumnName("PwdErrorNum");
           this.Property(t => t.PwdErrorTime).HasColumnName("PwdErrorTime");
           this.Property(t => t.SealPersonageKey).HasColumnName("SealPersonageKey");
           this.Property(t => t.SealCompanyKey).HasColumnName("SealCompanyKey");
           this.Property(t => t.CreditGrantingAmount).HasColumnName("CreditGrantingAmount");
           this.Property(t => t.UsedCreditGrantingAmount).HasColumnName("UsedCreditGrantingAmount");
           this.Property(t => t.PerformanceStartTime).HasColumnName("PerformanceStartTime");


           this.HasMany(t => t.B_UserBankInfo)
               .WithOptional(t=>t.B_UserBasicInfo)
               .HasForeignKey(d => d.UserId);

           this.HasMany(t => t.B_UserBankInfoLog)
               .WithOptional(t => t.B_UserBasicInfo)
               .HasForeignKey(d => d.UserId);
       }
    }
}
