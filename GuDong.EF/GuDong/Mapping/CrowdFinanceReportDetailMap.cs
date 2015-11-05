using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdFinanceReportDetailMap : EntityTypeConfiguration<CrowdFinanceReportDetail>
    {
        public CrowdFinanceReportDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DetailName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CrowdFinanceReportDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CrowdFinanceReport_Id).HasColumnName("CrowdFinanceReport_Id");
            this.Property(t => t.DetailType).HasColumnName("DetailType");
            this.Property(t => t.DetailName).HasColumnName("DetailName");
            this.Property(t => t.DetailNum).HasColumnName("DetailNum");
            this.Property(t => t.DetailAmount).HasColumnName("DetailAmount");

            // Relationships
            this.HasRequired(t => t.CrowdFinanceReport)
                .WithMany(t => t.CrowdFinanceReportDetails)
                .HasForeignKey(d => d.CrowdFinanceReport_Id);

        }
    }
}
