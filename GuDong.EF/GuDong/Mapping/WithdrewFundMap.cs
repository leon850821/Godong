using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class WithdrewFundMap : EntityTypeConfiguration<WithdrewFund>
    {
        public WithdrewFundMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WithdrawNo)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            this.Property(t => t.BankNo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RealName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.otherBankName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OpenBank)
                .HasMaxLength(100);

            this.Property(t => t.province)
                .HasMaxLength(100);

            this.Property(t => t.city)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("WithdrewFund");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.AppDate).HasColumnName("AppDate");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.AuditorId).HasColumnName("AuditorId");
            this.Property(t => t.HandingCharge).HasColumnName("HandingCharge");
            this.Property(t => t.ActualWithdrawDeposit).HasColumnName("ActualWithdrawDeposit");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.WithdrawNo).HasColumnName("WithdrawNo");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.BankNo).HasColumnName("BankNo");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.BankType).HasColumnName("BankType");
            this.Property(t => t.otherBankName).HasColumnName("otherBankName");
            this.Property(t => t.OpenBank).HasColumnName("OpenBank");
            this.Property(t => t.province).HasColumnName("province");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.AuditingDate).HasColumnName("AuditingDate");
            this.Property(t => t.RealHandFee).HasColumnName("RealHandFee");
        }
    }
}
