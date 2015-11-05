using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
   public  class MainModuleMap:EntityTypeConfiguration<MainModule>
    {
       public  MainModuleMap()
       {
           this.HasKey(t=>t.Id);
           this.Property(t => t.ModuleName)
               .IsRequired()
               .HasMaxLength(100);
           this.Property(t => t.Controller)
               .IsRequired()
               .HasMaxLength(100);
           this.Property(t => t.EditController)
               .IsRequired();

           this.ToTable("MainModule");
           this.Property(t => t.Id).HasColumnName("Id");
           this.Property(t => t.ModuleName).HasColumnName("ModuleName");
           this.Property(t => t.Controller).HasColumnName("Controller");
           this.Property(t => t.EditController).HasColumnName("EditController");
           this.Property(t => t.AddDate).HasColumnName("AddDate");
       }
    }
}
