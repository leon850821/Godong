using GuDong.Model.GoodJr;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.EF.GoodJr.Mapping
{
    public class B_UserBankInfoMap : EntityTypeConfiguration<B_UserBankInfo>
    {
        public B_UserBankInfoMap() {

            this.HasKey(t => t.Id);

            this.Property(t => t.BankAccountNo)
                .HasMaxLength(100);

            this.Property(t => t.BankProvice)
                .HasMaxLength(50);

            this.Property(t => t.BankCity)
                .HasMaxLength(50);

            this.Property(t => t.OpenBankName)
                .HasMaxLength(300);

            this.Property(t => t.otherBankName)
                .HasMaxLength(50);

            this.ToTable("B_UserBankInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.BankAccountNo).HasColumnName("BankAccountNo");
            this.Property(t => t.BankType).HasColumnName("BankType");
            this.Property(t => t.BankProvice).HasColumnName("BankProvice");
            this.Property(t => t.BankCity).HasColumnName("BankCity");
            this.Property(t => t.OpenBankName).HasColumnName("OpenBankName");
            this.Property(t => t.otherBankName).HasColumnName("otherBankName");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.AddData).HasColumnName("AddData");
            this.Property(t => t.Status).HasColumnName("Status");

            //this.HasRequired(t => t.B_UserBasicInfo)
            //    .WithMany()
            //    .HasForeignKey(d => d.UserId);
                
        }
    }
}
