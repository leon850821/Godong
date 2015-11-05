using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class AccountRechareMap : EntityTypeConfiguration<AccountRechare>
    {
        public AccountRechareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MediumOrderNo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BankCode)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("AccountRechare");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.HandlerUser).HasColumnName("HandlerUser");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.HandCharge).HasColumnName("HandCharge");
            this.Property(t => t.MediumOrderNo).HasColumnName("MediumOrderNo");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Realhandfee).HasColumnName("Realhandfee");
        }
    }
}
