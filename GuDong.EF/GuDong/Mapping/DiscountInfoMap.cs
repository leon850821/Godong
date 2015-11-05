using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class DiscountInfoMap : EntityTypeConfiguration<DiscountInfo>
    {
        public DiscountInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.LogoUrl)
                .HasMaxLength(255);

            this.Property(t => t.CreatePerson)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("DiscountInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Merchant_Id).HasColumnName("Merchant_Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.LogoUrl).HasColumnName("LogoUrl");
            this.Property(t => t.DiscountDesc).HasColumnName("DiscountDesc");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.CreatePerson).HasColumnName("CreatePerson");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasRequired(t => t.MerchantBasicInfo)
                .WithMany(t => t.DiscountInfoes)
                .HasForeignKey(d => d.Merchant_Id);

        }
    }
}
