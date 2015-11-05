using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdBookInfoMap : EntityTypeConfiguration<CrowdBookInfo>
    {
        public CrowdBookInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CrowdBookInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CrowdFunDingInfo_Id).HasColumnName("CrowdFunDingInfo_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.BookShare).HasColumnName("BookShare");
            this.Property(t => t.BookAmount).HasColumnName("BookAmount");
            this.Property(t => t.BookDate).HasColumnName("BookDate");

            // Relationships
            this.HasRequired(t => t.CrowdFunDingInfo)
                .WithMany(t => t.CrowdBookInfoes)
                .HasForeignKey(d => d.CrowdFunDingInfo_Id);

        }
    }
}
