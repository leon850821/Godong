using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GuDong.EF.GuDong.Mapping;
using GuDong.Model.GuDong;
using System;

namespace GuDong.EF.GuDong
{
    public partial class GuDongContext : DbContext
    {
        //static GuDongContext()
        //{
        //    Database.SetInitializer<GuDongContext>(null);
        //}

        public GuDongContext()
            : base("Name=GuDongContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        
        public virtual int SaveChanges() {
            
            return base.SaveChanges();
        }

        public DbSet<AccountRechare> AccountRechare { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<CodeRecord> CodeRecord { get; set; }
        public DbSet<CrowdBookInfo> CrowdBookInfoe { get; set; }
        public DbSet<CrowdFinanceReport> CrowdFinanceReport { get; set; }
        public DbSet<CrowdFinanceReportDetail> CrowdFinanceReportDetail { get; set; }
        public DbSet<CrowdFunDingInfo> CrowdFunDingInfoe { get; set; }
        public DbSet<CrowdInvestment> CrowdInvestment { get; set; }
        public DbSet<DiscountInfo> DiscountInfoe { get; set; }
        public DbSet<FundAccountInfo> FundAccountInfoe { get; set; }
        public DbSet<IndustryInfo> IndustryInfoe { get; set; }
        public DbSet<MerchantBasicInfo> MerchantBasicInfoe { get; set; }
        public DbSet<MerchantSettledApply> MerchantSettledApplie { get; set; }
        public DbSet<MoneyHistory> MoneyHistorie { get; set; }
        public DbSet<WithdrewFund> WithdrewFund { get; set; }
        public DbSet<CrowdBonusList> CrowdBonusList { get; set; }
        public DbSet<NewInfo> NewInfo { get; set; }
        public DbSet<ModuleList> ModuleList { get; set; }
        public DbSet<MainModule> MainModule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountRechareMap());
            modelBuilder.Configurations.Add(new BannerMap());
            modelBuilder.Configurations.Add(new CodeRecordMap());
            modelBuilder.Configurations.Add(new CrowdBookInfoMap());
            modelBuilder.Configurations.Add(new CrowdFinanceReportMap());
            modelBuilder.Configurations.Add(new CrowdFinanceReportDetailMap());
            modelBuilder.Configurations.Add(new CrowdFunDingInfoMap());
            modelBuilder.Configurations.Add(new CrowdInvestmentMap());
            modelBuilder.Configurations.Add(new DiscountInfoMap());
            modelBuilder.Configurations.Add(new FundAccountInfoMap());
            modelBuilder.Configurations.Add(new IndustryInfoMap());
            modelBuilder.Configurations.Add(new MerchantBasicInfoMap());
            modelBuilder.Configurations.Add(new MerchantSettledApplyMap());
            modelBuilder.Configurations.Add(new MoneyHistoryMap());
            modelBuilder.Configurations.Add(new WithdrewFundMap());
            modelBuilder.Configurations.Add(new CrowdBonusListMap());
            modelBuilder.Configurations.Add(new NewInfoMap());
            modelBuilder.Configurations.Add(new MainModuleMap());
            modelBuilder.Configurations.Add(new ModuleListMap());
            
        }
    }
}
