using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.EF.GuDong.Mapping
{
    public class NewInfoMap : EntityTypeConfiguration<NewInfo>
    {
        public NewInfoMap() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Image)
                .HasMaxLength(250);

            this.ToTable("NewInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.ClickNumber).HasColumnName("ClickNumber");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.IsShow).HasColumnName("IsShow");
            this.Property(t => t.IsTop).HasColumnName("IsTop");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Image).HasColumnName("Image");

        }
    }
}
