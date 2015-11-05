using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace GuDong.EF.GuDong.Mapping
{
    public class ModuleListMap : EntityTypeConfiguration<ModuleList>
    {
        public ModuleListMap()
        {
            this.HasKey(t=>t.Id);

            this.Property(t => t.ModuleName)
               .IsRequired()
               .HasMaxLength(100);

            this.Property(t => t.Controller)
               .IsRequired()
               .HasMaxLength(100);

            this.Property(t => t.Action)
               .HasMaxLength(100);

            this.Property(t => t.EditController)
              .IsRequired()
              .HasMaxLength(100);

            this.Property(t => t.EditAction)
               .HasMaxLength(100);

            this.Property(t => t.AddDate)
                .IsRequired();

            this.Property(t => t.MainModuleId);

            this.ToTable("ModuleList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.Controller).HasColumnName("Controller");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.EditController).HasColumnName("EditController");
            this.Property(t => t.EditAction).HasColumnName("EditAction");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
 

             this.HasRequired(t => t.MainModule)
                .WithMany(t => t.ModuleList)
                .HasForeignKey(d => d.MainModuleId);

        }
    }
}
