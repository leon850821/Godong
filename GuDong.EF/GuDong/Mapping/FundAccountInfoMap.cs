using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class FundAccountInfoMap : EntityTypeConfiguration<FundAccountInfo>
    {
        public FundAccountInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("FundAccountInfo");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.AviMoney).HasColumnName("AviMoney");
            this.Property(t => t.FreezeAcount).HasColumnName("FreezeAcount");
            this.Property(t => t.Integral).HasColumnName("Integral");
            this.Property(t => t.FreezeIntegral).HasColumnName("FreezeIntegral");
            this.Property(t => t.RewardMoney).HasColumnName("RewardMoney");
        }
    }
}
