USE [ATF_Bank]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 27.02.2023 18:24:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[u_login] [varchar](50) NOT NULL,
	[u_password] [varchar](50) NOT NULL,
	[u_name] [varchar](50) NULL,
	[u_surname] [varchar](50) NULL,
	[u_email] [varchar](50) NULL,
	[u_phoneNumber] [varchar](50) NULL,
	[u_currentMoney] [int] NULL,
	[u_increasedMoney] [int] NULL,
	[u_decreasedMoney] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF__USERS__u_current__36B12243]  DEFAULT ((0)) FOR [u_currentMoney]
GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF__USERS__u_increas__37A5467C]  DEFAULT ((0)) FOR [u_increasedMoney]
GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF__USERS__u_decreas__38996AB5]  DEFAULT ((0)) FOR [u_decreasedMoney]
GO
