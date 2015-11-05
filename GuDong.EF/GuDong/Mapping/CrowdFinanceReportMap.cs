using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdFinanceReportMap : EntityTypeConfiguration<CrowdFinanceReport>
    {
        public CrowdFinanceReportMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ReportTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReportDesc)
                .HasMaxLength(255);

            this.Property(t => t.AuditPerson)
                .HasMaxLength(30);

            this.Property(t => t.CreatePerson)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CrowdFinanceReport");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CrowdFunDingInfo_Id).HasColumnName("CrowdFunDingInfo_Id");
            this.Property(t => t.ReportStartDate).HasColumnName("ReportStartDate");
            this.Property(t => t.ReportEndDate).HasColumnName("ReportEndDate");
            this.Property(t => t.ReportTitle).HasColumnName("ReportTitle");
            this.Property(t => t.ReportDesc).HasColumnName("ReportDesc");
            this.Property(t => t.IsProfit).HasColumnName("IsProfit");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.AuditPerson).HasColumnName("AuditPerson");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreatePerson).HasColumnName("CreatePerson");

            // Relationships
            this.HasRequired(t => t.CrowdFunDingInfo)
                .WithMany(t => t.CrowdFinanceReports)
                .HasForeignKey(d => d.CrowdFunDingInfo_Id);

        }
    }
}
