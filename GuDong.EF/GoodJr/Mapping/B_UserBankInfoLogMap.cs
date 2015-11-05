using GuDong.Model.GoodJr;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace GuDong.EF.GoodJr.Mapping
{
    public  class B_UserBankInfoLogMap : EntityTypeConfiguration<B_UserBankInfoLog>
    {
        public B_UserBankInfoLogMap(){

            this.HasKey(t => t.Id);

            this.Property(t => t.BankNo)
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.OpenName)
                .HasMaxLength(100);

            this.Property(t => t.RealName)
                .HasMaxLength(50);

            this.Property(t => t.UpdateUser)
                .HasMaxLength(50);

            this.Property(t => t.CardNo)
                .HasMaxLength(50);

            this.ToTable("B_UserBankInfoLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.BankNo).HasColumnName("BankNo");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.OpenName).HasColumnName("OpenName");
            this.Property(t => t.RealName).HasColumnName("RealName");
            this.Property(t => t.AddDate).HasColumnName("AddDate");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.CardNo).HasColumnName("CardNo");

            //this.HasRequired(t => t.B_UserBasicInfo)
            //    .WithMany(t => t.B_UserBankInfoLog)
            //    .HasForeignKey(t => t.UserId);
        }
    }
}
