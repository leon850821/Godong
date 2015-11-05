using GuDong.Model.GuDong;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GuDong.EF.GuDong.Mapping
{
    public class MerchantBasicInfoMap : EntityTypeConfiguration<MerchantBasicInfo>
    {
        public MerchantBasicInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MerchantName)
                .HasMaxLength(128);

            this.Property(t => t.LegalName)
                .HasMaxLength(64);

            this.Property(t => t.RegistrationNo)
                .HasMaxLength(64);

            this.Property(t => t.OrganizationCode)
                .HasMaxLength(64);

            this.Property(t => t.Address)
                .HasMaxLength(128);

            this.Property(t => t.EnterpriseDescription)
                .HasMaxLength(255);

            this.Property(t => t.BusinessDescription)
                .HasMaxLength(255);

            this.Property(t => t.RegistrationAuthority)
                .HasMaxLength(100);

            this.Property(t => t.BusinessRange)
                .HasMaxLength(255);

            this.Property(t => t.LogoUrl)
                .HasMaxLength(255);

            this.Property(t => t.ContactName)
                .HasMaxLength(64);

            this.Property(t => t.ContactPhone)
                .HasMaxLength(64);

            this.Property(t => t.ContactMobilePhone)
                .HasMaxLength(64);

            this.Property(t => t.ContactFax)
                .HasMaxLength(64);

            this.Property(t => t.ContactAddress)
                .HasMaxLength(128);

            this.Property(t => t.ContactZip)
                .HasMaxLength(64);

            this.Property(t => t.LegalCredentialsNumImg)
                .HasMaxLength(255);

            this.Property(t => t.LegalCreditReportImg)
                .HasMaxLength(255);

            this.Property(t => t.BusinessLicenseImg)
                .HasMaxLength(255);

            this.Property(t => t.TaxRegistrationImg)
                .HasMaxLength(255);

            this.Property(t => t.OrganizationCodeImg)
                .HasMaxLength(255);

            this.Property(t => t.CompanyImgImg)
                .HasMaxLength(255);

            this.Property(t => t.LeaseContractImg)
                .HasMaxLength(255);

            this.Property(t => t.TradeLicenseImg)
                .HasMaxLength(255);

            this.Property(t => t.CreateUser)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MerchantBasicInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.MerchantName).HasColumnName("MerchantName");
            this.Property(t => t.LegalName).HasColumnName("LegalName");
            this.Property(t => t.IndustryInfo_Id).HasColumnName("IndustryInfo_Id");
            this.Property(t => t.IndustryInfo_ChildId).HasColumnName("IndustryInfo_ChildId");
            this.Property(t => t.RegistrationNo).HasColumnName("RegistrationNo");
            this.Property(t => t.OrganizationCode).HasColumnName("OrganizationCode");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.RegisteredCapital).HasColumnName("RegisteredCapital");
            this.Property(t => t.EnterpriseDescription).HasColumnName("EnterpriseDescription");
            this.Property(t => t.BusinessDescription).HasColumnName("BusinessDescription");
            this.Property(t => t.OpeningDate).HasColumnName("OpeningDate");
            this.Property(t => t.RegistrationAuthority).HasColumnName("RegistrationAuthority");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.BusinessRange).HasColumnName("BusinessRange");
            this.Property(t => t.LogoUrl).HasColumnName("LogoUrl");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactPhone).HasColumnName("ContactPhone");
            this.Property(t => t.ContactMobilePhone).HasColumnName("ContactMobilePhone");
            this.Property(t => t.ContactFax).HasColumnName("ContactFax");
            this.Property(t => t.ContactAddress).HasColumnName("ContactAddress");
            this.Property(t => t.ContactZip).HasColumnName("ContactZip");
            this.Property(t => t.BranchNum).HasColumnName("BranchNum");
            this.Property(t => t.LegalCredentialsNumImg).HasColumnName("LegalCredentialsNumImg");
            this.Property(t => t.LegalCreditReportImg).HasColumnName("LegalCreditReportImg");
            this.Property(t => t.BusinessLicenseImg).HasColumnName("BusinessLicenseImg");
            this.Property(t => t.TaxRegistrationImg).HasColumnName("TaxRegistrationImg");
            this.Property(t => t.OrganizationCodeImg).HasColumnName("OrganizationCodeImg");
            this.Property(t => t.CompanyImgImg).HasColumnName("CompanyImgImg");
            this.Property(t => t.LeaseContractImg).HasColumnName("LeaseContractImg");
            this.Property(t => t.TradeLicenseImg).HasColumnName("TradeLicenseImg");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasOptional(t => t.IndustryInfo)
                .WithMany(t => t.MerchantBasicInfoes)
                .HasForeignKey(d => d.IndustryInfo_Id);
            this.HasOptional(t => t.IndustryInfo1)
                .WithMany(t => t.MerchantBasicInfoes1)
                .HasForeignKey(d => d.IndustryInfo_ChildId);

        }
    }
}
