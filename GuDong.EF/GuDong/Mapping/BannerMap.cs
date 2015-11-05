using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        public BannerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkUrl)
                .HasMaxLength(250);

            this.Property(t => t.Image)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Banner");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.LinkUrl).HasColumnName("LinkUrl");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.Sort).HasColumnName("Sort");
            this.Property(t => t.AddTime).HasColumnName("AddTime");
        }
    }
}
