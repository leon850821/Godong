using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class MerchantSettledApplyMap : EntityTypeConfiguration<MerchantSettledApply>
    {
        public MerchantSettledApplyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TelNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RealName)
                .IsRequired()
                .HasMaxLength(20);


            this.Property(t => t.ApplyDesc)
                .HasMaxLength(255);

            this.Property(t => t.AcceptancePerson)
               .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MerchantSettledApply");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TelNo).HasColumnName("TelNo");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.ApplyDesc).HasColumnName("ApplyDesc");
            this.Property(t => t.ApplyState).HasColumnName("ApplyState");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.AcceptancePerson).HasColumnName("AcceptancePerson");
            this.Property(t => t.AcceptanceDate).HasColumnName("AcceptanceDate");
        }
    }
}
