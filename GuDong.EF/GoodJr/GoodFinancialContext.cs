using System.Data.Entity;
using GuDong.Model.GoodJr;
using GuDong.EF.GoodJr.Mapping;
using System;
using System.Data.Entity.Infrastructure;

namespace GuDong.EF.GoodJr
{ 

    public partial class GoodFinancialContext : DbContext
    {
        public GoodFinancialContext()
            : base("name=GoodFinancialContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<B_UserBankInfo> B_UserBankInfo { get; set;  }
        public virtual DbSet<B_UserBankInfoLog> B_UserBankInfoLog { get; set; }
        public virtual DbSet<B_UserBasicInfo> B_UserBasicInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new B_UserBankInfoMap());
            modelBuilder.Configurations.Add(new B_UserBankInfoLogMap());
            modelBuilder.Configurations.Add(new B_UserBasicInfoMap());
        }
    }
}
