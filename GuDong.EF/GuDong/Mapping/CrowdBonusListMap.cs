using GuDong.Model.GuDong;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.EF.GuDong.Mapping
{
    public class CrowdBonusListMap : EntityTypeConfiguration<CrowdBonusList>
    {
        public CrowdBonusListMap() {

            // Primary Key
            this.HasKey(t => t.Id);

            this.ToTable("CrowdBonusList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CrowdFunDingInfo_Id).HasColumnName("CrowdFunDingInfo_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.BonusAmount).HasColumnName("BonusAmount");
            this.Property(t => t.BonusShare).HasColumnName("BonusShare");
            this.Property(t => t.BonusDate).HasColumnName("BonusDate");
        }
    }
}
