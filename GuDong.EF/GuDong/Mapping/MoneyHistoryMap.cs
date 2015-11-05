using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class MoneyHistoryMap : EntityTypeConfiguration<MoneyHistory>
    {
        public MoneyHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("MoneyHistory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.RewardMoney).HasColumnName("RewardMoney");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
        }
    }
}
