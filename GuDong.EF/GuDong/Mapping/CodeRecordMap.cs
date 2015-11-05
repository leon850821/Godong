using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class CodeRecordMap : EntityTypeConfiguration<CodeRecord>
    {
        public CodeRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ToNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CodeRecord");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ToNumber).HasColumnName("ToNumber");
        }
    }
}
