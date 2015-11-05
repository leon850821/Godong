using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdFunDingInfoMap : EntityTypeConfiguration<CrowdFunDingInfo>
    {
        public CrowdFunDingInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.LogoUrl)
                .HasMaxLength(255);

            this.Property(t => t.CrowdCover)
                .HasMaxLength(255);

            this.Property(t => t.CrowdAddress)
                .HasMaxLength(255);

            this.Property(t => t.CreatePerson)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.AuditPerson)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CrowdFunDingInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Merchant_Id).HasColumnName("Merchant_Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.LogoUrl).HasColumnName("LogoUrl");
            this.Property(t => t.CrowdCover).HasColumnName("CrowdCover");
            this.Property(t => t.CrowdDesc).HasColumnName("CrowdDesc");
            this.Property(t => t.CrowdAddress).HasColumnName("CrowdAddress");
            this.Property(t => t.ContributionAmount).HasColumnName("ContributionAmount");
            this.Property(t => t.ContributionShare).HasColumnName("ContributionShare");
            this.Property(t => t.CrowdAmount).HasColumnName("CrowdAmount");
            this.Property(t => t.LowerUnit).HasColumnName("LowerUnit");
            this.Property(t => t.CrowdShare).HasColumnName("CrowdShare");
            this.Property(t => t.InvestmentShare).HasColumnName("InvestmentShare");
            this.Property(t => t.CrowdDays).HasColumnName("CrowdDays");
            this.Property(t => t.CrowdStartDate).HasColumnName("CrowdStartDate");
            this.Property(t => t.DividendsDay).HasColumnName("DividendsDay");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.CrowdState).HasColumnName("CrowdState");
            this.Property(t => t.IsHot).HasColumnName("IsHot");
            this.Property(t => t.AttentionNum).HasColumnName("AttentionNum");
            this.Property(t => t.CreatePerson).HasColumnName("CreatePerson");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.AuditPerson).HasColumnName("AuditPerson");
            this.Property(t => t.AuditDate).HasColumnName("AuditDate");

            // Relationships
            this.HasRequired(t => t.MerchantBasicInfo)
                .WithMany(t => t.CrowdFunDingInfoes)
                .HasForeignKey(d => d.Merchant_Id);

            this.HasMany(t => t.CrowdBonusList)
                .WithRequired(t => t.CrowdFunDingInfo)
                .HasForeignKey(d => d.CrowdFunDingInfo_Id);

        }
    }
}
