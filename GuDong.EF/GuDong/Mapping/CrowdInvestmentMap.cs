using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdInvestmentMap : EntityTypeConfiguration<CrowdInvestment>
    {
        public CrowdInvestmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CrowdInvestment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CrowdFunDingInfo_Id).HasColumnName("CrowdFunDingInfo_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.InvestmentType).HasColumnName("InvestmentType");
            this.Property(t => t.InvestmentShare).HasColumnName("InvestmentShare");
            this.Property(t => t.InvestmentAmount).HasColumnName("InvestmentAmount");
            this.Property(t => t.ProportionOf).HasColumnName("ProportionOf");
            this.Property(t => t.DividendsOf).HasColumnName("DividendsOf");
            this.Property(t => t.InvestmentDate).HasColumnName("InvestmentDate");

            // Relationships
            this.HasRequired(t => t.CrowdFunDingInfo)
                .WithMany(t => t.CrowdInvestments)
                .HasForeignKey(d => d.CrowdFunDingInfo_Id);

        }
    }
}
