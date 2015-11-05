using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class IndustryInfoMap : EntityTypeConfiguration<IndustryInfo>
    {
        public IndustryInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.IndustryName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IndustryInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IndustryName).HasColumnName("IndustryName");
            this.Property(t => t.IndustryIco).HasColumnName("IndustryIco");
            this.Property(t => t.Industry_Pid).HasColumnName("Industry_Pid");

            // Relationships
            this.HasOptional(t => t.IndustryInfo2)
                .WithMany(t => t.IndustryInfo1)
                .HasForeignKey(d => d.Industry_Pid);

        }
    }
}
