USE [GuDong]
GO
/****** Object:  Table [dbo].[WithdrewFund]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WithdrewFund](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Amount] [money] NOT NULL,
	[Status] [int] NOT NULL,
	[AppDate] [datetime] NULL,
	[AuditDate] [datetime] NULL,
	[AuditorId] [uniqueidentifier] NULL,
	[HandingCharge] [numeric](18, 2) NULL,
	[ActualWithdrawDeposit] [numeric](18, 2) NULL,
	[type] [int] NOT NULL,
	[WithdrawNo] [nvarchar](30) NOT NULL,
	[Memo] [nvarchar](1000) NULL,
	[BankNo] [nvarchar](100) NOT NULL,
	[RealName] [nvarchar](50) NOT NULL,
	[BankType] [int] NOT NULL,
	[otherBankName] [nvarchar](50) NOT NULL,
	[OpenBank] [nvarchar](100) NULL,
	[province] [nvarchar](100) NULL,
	[city] [nvarchar](100) NULL,
	[AuditingDate] [datetime] NULL,
	[RealHandFee] [numeric](18, 2) NULL,
 CONSTRAINT [PK_WithdrewFund_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户提现信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'提现金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'AppDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核完成付款时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'AuditDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'AuditorId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手续费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'HandingCharge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际提现' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'ActualWithdrawDeposit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'WithdrawNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'BankNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'RealName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'BankType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行名称（其他）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'otherBankName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开户行' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'OpenBank'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'province'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'city'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核中处理时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'AuditingDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际手续费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'WithdrewFund', @level2type=N'COLUMN',@level2name=N'RealHandFee'
GO
/****** Object:  Table [dbo].[NewInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Content] [ntext] NULL,
	[ClickNumber] [int] NULL,
	[AddDate] [datetime] NULL,
	[IsShow] [bit] NULL,
	[IsTop] [bit] NULL,
	[Type] [int] NULL,
	[Image] [nvarchar](250) NULL,
 CONSTRAINT [PK_NewInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoneyHistory]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoneyHistory](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[RewardMoney] [numeric](18, 2) NOT NULL,
	[Amount] [numeric](18, 2) NOT NULL,
	[Memo] [nvarchar](1000) NULL,
	[AddDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MoneyHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'资金变化记录' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'RewardMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'余额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MoneyHistory', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
/****** Object:  Table [dbo].[MerchantSettledApply]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchantSettledApply](
	[Id] [uniqueidentifier] NOT NULL,
	[TelNo] [nvarchar](20) NOT NULL,
	[RealName] [nvarchar](20) NOT NULL,
	[Sex] [nvarchar](5) NOT NULL,
	[ApplyDesc] [nvarchar](255) NULL,
	[ApplyState] [int] NOT NULL,
	[ApplyDate] [datetime] NOT NULL,
	[AcceptancePerson] [nvarchar](50) NULL,
	[AcceptanceDate] [datetime] NULL,
 CONSTRAINT [PK_MerchantSettledApply_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MerchantBasicInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchantBasicInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[MerchantName] [nvarchar](128) NULL,
	[LegalName] [nvarchar](64) NULL,
	[IndustryInfo_Id] [uniqueidentifier] NULL,
	[IndustryInfo_ChildId] [uniqueidentifier] NULL,
	[RegistrationNo] [nvarchar](64) NULL,
	[OrganizationCode] [nvarchar](64) NULL,
	[Address] [nvarchar](128) NULL,
	[RegisteredCapital] [decimal](18, 2) NULL,
	[EnterpriseDescription] [nvarchar](255) NULL,
	[BusinessDescription] [nvarchar](255) NULL,
	[OpeningDate] [datetime] NULL,
	[RegistrationAuthority] [nvarchar](100) NULL,
	[BusinessDate] [datetime] NULL,
	[BusinessRange] [nvarchar](255) NULL,
	[LogoUrl] [nvarchar](255) NULL,
	[ContactName] [nvarchar](64) NULL,
	[ContactPhone] [nvarchar](64) NULL,
	[ContactMobilePhone] [nvarchar](64) NULL,
	[ContactFax] [nvarchar](64) NULL,
	[ContactAddress] [nvarchar](128) NULL,
	[ContactZip] [nvarchar](64) NULL,
	[BranchNum] [int] NULL,
	[LegalCredentialsNumImg] [nvarchar](255) NULL,
	[LegalCreditReportImg] [nvarchar](255) NULL,
	[BusinessLicenseImg] [nvarchar](255) NULL,
	[TaxRegistrationImg] [nvarchar](255) NULL,
	[OrganizationCodeImg] [nvarchar](255) NULL,
	[CompanyImgImg] [nvarchar](255) NULL,
	[LeaseContractImg] [nvarchar](255) NULL,
	[TradeLicenseImg] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[CreateUser] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MerchantBasicInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IndustryInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndustryInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[IndustryName] [nvarchar](50) NOT NULL,
	[IndustryIco] [nvarchar](255) NULL,
	[Industry_Pid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_IndustryInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundAccountInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundAccountInfo](
	[User_Id] [uniqueidentifier] NOT NULL,
	[AviMoney] [numeric](18, 2) NOT NULL,
	[FreezeAcount] [numeric](18, 2) NOT NULL,
	[Integral] [int] NOT NULL,
	[FreezeIntegral] [int] NOT NULL,
	[RewardMoney] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_FUNDACCOUNTINFO] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'资金账户信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'User_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'可用现金金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'AviMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'冻结金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'FreezeAcount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'积分' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'Integral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'冻结积分' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'FreezeIntegral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'奖金金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FundAccountInfo', @level2type=N'COLUMN',@level2name=N'RewardMoney'
GO
/****** Object:  Table [dbo].[DiscountInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiscountInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[Merchant_Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[LogoUrl] [nvarchar](255) NULL,
	[DiscountDesc] [text] NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Sort] [int] NOT NULL,
	[CreatePerson] [nvarchar](30) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_DiscountInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdInvestment]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdInvestment](
	[Id] [uniqueidentifier] NOT NULL,
	[CrowdFunDingInfo_Id] [uniqueidentifier] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[InvestmentType] [int] NOT NULL,
	[InvestmentShare] [int] NOT NULL,
	[InvestmentAmount] [numeric](18, 2) NOT NULL,
	[ProportionOf] [numeric](18, 2) NOT NULL,
	[DividendsOf] [numeric](18, 2) NOT NULL,
	[InvestmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CrowdInvestment_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdFunDingInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdFunDingInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[Merchant_Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[LogoUrl] [nvarchar](255) NULL,
	[CrowdCover] [nvarchar](255) NULL,
	[CrowdDesc] [text] NULL,
	[CrowdAddress] [nvarchar](255) NULL,
	[ContributionAmount] [numeric](18, 2) NOT NULL,
	[ContributionShare] [numeric](18, 2) NOT NULL,
	[InvestmentShare] [int] NOT NULL,
	[CrowdAmount] [numeric](18, 2) NOT NULL,
	[LowerUnit] [numeric](18, 2) NOT NULL,
	[CrowdShare] [int] NOT NULL,
	[CrowdDays] [int] NOT NULL,
	[CrowdStartDate] [datetime] NOT NULL,
	[DividendsDay] [int] NOT NULL,
	[BusinessDate] [datetime] NULL,
	[CrowdState] [int] NOT NULL,
	[IsHot] [bit] NOT NULL,
	[AttentionNum] [int] NOT NULL,
	[CreatePerson] [nvarchar](30) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[AuditPerson] [nvarchar](30) NULL,
	[AuditDate] [datetime] NULL,
 CONSTRAINT [PK_CrowdFunDingInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdFinanceReportDetail]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdFinanceReportDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[CrowdFinanceReport_Id] [uniqueidentifier] NOT NULL,
	[DetailType] [int] NOT NULL,
	[DetailName] [nvarchar](50) NOT NULL,
	[DetailNum] [int] NOT NULL,
	[DetailAmount] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_CrowdFinanceReportDetail_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdFinanceReport]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdFinanceReport](
	[Id] [uniqueidentifier] NOT NULL,
	[CrowdFunDingInfo_Id] [uniqueidentifier] NOT NULL,
	[ReportStartDate] [datetime] NOT NULL,
	[ReportEndDate] [datetime] NOT NULL,
	[ReportTitle] [nvarchar](50) NOT NULL,
	[ReportDesc] [nvarchar](255) NULL,
	[IsProfit] [int] NOT NULL,
	[State] [int] NOT NULL,
	[AuditPerson] [nvarchar](30) NULL,
	[AuditDate] [datetime] NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreatePerson] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_CrowdFinanceReport_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdBookInfo]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdBookInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[CrowdFunDingInfo_Id] [uniqueidentifier] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[BookShare] [int] NOT NULL,
	[BookAmount] [numeric](18, 2) NOT NULL,
	[BookDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CrowdBookInfo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrowdBonusList]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrowdBonusList](
	[Id] [uniqueidentifier] NOT NULL,
	[CrowdFunDingInfo_Id] [int] NOT NULL,
	[User_Id] [uniqueidentifier] NOT NULL,
	[BonusAmount] [numeric](18, 2) NOT NULL,
	[BonusShare] [numeric](18, 2) NOT NULL,
	[BonusDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CrowdBonusList_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeRecord]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeRecord](
	[Id] [uniqueidentifier] NOT NULL,
	[Status] [int] NOT NULL,
	[Code] [nvarchar](100) NOT NULL,
	[AddDate] [datetime] NOT NULL,
	[Type] [int] NOT NULL,
	[ToNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CodeRecord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CodeRecord', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消息码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CodeRecord', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CodeRecord', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CodeRecord', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'接收对象' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CodeRecord', @level2type=N'COLUMN',@level2name=N'ToNumber'
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
	[LinkUrl] [nvarchar](250) NULL,
	[Image] [nvarchar](250) NOT NULL,
	[Sort] [int] NOT NULL,
	[AddTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountRechare]    Script Date: 06/25/2015 17:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountRechare](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AddDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[HandlerUser] [nvarchar](30) NULL,
	[Amount] [numeric](18, 2) NOT NULL,
	[HandCharge] [numeric](18, 2) NOT NULL,
	[MediumOrderNo] [nvarchar](100) NOT NULL,
	[BankCode] [nvarchar](50) NULL,
	[Memo] [nvarchar](1000) NULL,
	[Realhandfee] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_AccountRechare] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'AddDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处理时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'处理人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'HandlerUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手续费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'HandCharge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'第三方订单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'MediumOrderNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'银行代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'BankCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'Memo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实手续费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AccountRechare', @level2type=N'COLUMN',@level2name=N'Realhandfee'
GO
/****** Object:  Default [DF_AccountRechare_Amount]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[AccountRechare] ADD  CONSTRAINT [DF_AccountRechare_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_AccountRechare_HandCharge]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[AccountRechare] ADD  CONSTRAINT [DF_AccountRechare_HandCharge]  DEFAULT ((0)) FOR [HandCharge]
GO
/****** Object:  Default [DF_AccountRechare_Realhandfee]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[AccountRechare] ADD  CONSTRAINT [DF_AccountRechare_Realhandfee]  DEFAULT ((0)) FOR [Realhandfee]
GO
/****** Object:  Default [DF_Banner_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[Banner] ADD  CONSTRAINT [DF_Banner_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_CrowdFunDingInfo_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[CrowdFunDingInfo] ADD  CONSTRAINT [DF_CrowdFunDingInfo_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_CrowdFunDingInfo_Merchant_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[CrowdFunDingInfo] ADD  CONSTRAINT [DF_CrowdFunDingInfo_Merchant_Id]  DEFAULT (newid()) FOR [Merchant_Id]
GO
/****** Object:  Default [DF_CrowdFunDingInfo_InvestmentShare]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[CrowdFunDingInfo] ADD  CONSTRAINT [DF_CrowdFunDingInfo_InvestmentShare]  DEFAULT ((0)) FOR [InvestmentShare]
GO
/****** Object:  Default [DF_CrowdFunDingInfo_AttentionNum]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[CrowdFunDingInfo] ADD  CONSTRAINT [DF_CrowdFunDingInfo_AttentionNum]  DEFAULT ((0)) FOR [AttentionNum]
GO
/****** Object:  Default [DF_DiscountInfo_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[DiscountInfo] ADD  CONSTRAINT [DF_DiscountInfo_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_DiscountInfo_Merchant_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[DiscountInfo] ADD  CONSTRAINT [DF_DiscountInfo_Merchant_Id]  DEFAULT (newid()) FOR [Merchant_Id]
GO
/****** Object:  Default [DF_DiscountInfo_Sort]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[DiscountInfo] ADD  CONSTRAINT [DF_DiscountInfo_Sort]  DEFAULT ((0)) FOR [Sort]
GO
/****** Object:  Default [DF_FundAccountInfo_AviMoney]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[FundAccountInfo] ADD  CONSTRAINT [DF_FundAccountInfo_AviMoney]  DEFAULT ((0)) FOR [AviMoney]
GO
/****** Object:  Default [DF_FundAccountInfo_FreezeAcount]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[FundAccountInfo] ADD  CONSTRAINT [DF_FundAccountInfo_FreezeAcount]  DEFAULT ((0)) FOR [FreezeAcount]
GO
/****** Object:  Default [DF_FundAccountInfo_FreezeIntegral]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[FundAccountInfo] ADD  CONSTRAINT [DF_FundAccountInfo_FreezeIntegral]  DEFAULT ((0)) FOR [FreezeIntegral]
GO
/****** Object:  Default [DF_FundAccountInfo_RewardMoney]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[FundAccountInfo] ADD  CONSTRAINT [DF_FundAccountInfo_RewardMoney]  DEFAULT ((0)) FOR [RewardMoney]
GO
/****** Object:  Default [DF_IndustryInfo_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[IndustryInfo] ADD  CONSTRAINT [DF_IndustryInfo_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_MerchantBasicInfo_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[MerchantBasicInfo] ADD  CONSTRAINT [DF_MerchantBasicInfo_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_NewInfo_Id]    Script Date: 06/25/2015 17:30:02 ******/
ALTER TABLE [dbo].[NewInfo] ADD  CONSTRAINT [DF_NewInfo_Id]  DEFAULT (newid()) FOR [Id]
GO

select * from   dbo.ModuleList 

CREATE TABLE [dbo].[ModuleList](
	[Id] [uniqueidentifier] NOT NULL,
	[ModuleName] [nvarchar](100) NOT NULL,
	[Controller] [nvarchar](100) NOT NULL,
	[Action] [nvarchar](100) NULL,
	[EditController] [nvarchar](100) NOT NULL,
	[EditAction] [nvarchar](100) NULL,
	[AddDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ModuleList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [ModuleList] DROP COLUMN [AddTime] 

ALTER TABLE [ModuleList] add [AddDate] [datetime] NOT NULL