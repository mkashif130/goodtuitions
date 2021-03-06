USE [master]
GO
/****** Object:  Database [GoodTuitions]    Script Date: 01/31/2014 01:36:06 ******/
CREATE DATABASE [GoodTuitions] ON  PRIMARY 
( NAME = N'GoodTuitions', FILENAME = N'E:\MyDatabases\GoodTuitions.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GoodTuitions_log', FILENAME = N'E:\MyDatabases\GoodTuitions_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GoodTuitions] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GoodTuitions].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GoodTuitions] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [GoodTuitions] SET ANSI_NULLS OFF
GO
ALTER DATABASE [GoodTuitions] SET ANSI_PADDING OFF
GO
ALTER DATABASE [GoodTuitions] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [GoodTuitions] SET ARITHABORT OFF
GO
ALTER DATABASE [GoodTuitions] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [GoodTuitions] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [GoodTuitions] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [GoodTuitions] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [GoodTuitions] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [GoodTuitions] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [GoodTuitions] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [GoodTuitions] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [GoodTuitions] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [GoodTuitions] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [GoodTuitions] SET  DISABLE_BROKER
GO
ALTER DATABASE [GoodTuitions] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [GoodTuitions] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [GoodTuitions] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [GoodTuitions] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [GoodTuitions] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [GoodTuitions] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [GoodTuitions] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [GoodTuitions] SET  READ_WRITE
GO
ALTER DATABASE [GoodTuitions] SET RECOVERY SIMPLE
GO
ALTER DATABASE [GoodTuitions] SET  MULTI_USER
GO
ALTER DATABASE [GoodTuitions] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [GoodTuitions] SET DB_CHAINING OFF
GO
USE [GoodTuitions]
GO
/****** Object:  Table [dbo].[cor_users]    Script Date: 01/31/2014 01:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cor_users](
	[email_address] [nvarchar](80) NOT NULL,
	[user_name] [nvarchar](80) NOT NULL,
	[first_name] [nvarchar](80) NOT NULL,
	[last_name] [nvarchar](80) NOT NULL,
	[registration_datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_cor_users] PRIMARY KEY CLUSTERED 
(
	[email_address] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cor_profile]    Script Date: 01/31/2014 01:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cor_profile](
	[email_address] [nvarchar](80) NOT NULL,
	[cell_number] [nvarchar](50) NULL,
	[telephone_number] [nvarchar](50) NULL,
	[address] [nvarchar](200) NULL,
	[country] [nvarchar](50) NULL,
	[province] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
 CONSTRAINT [PK_cor_profile] PRIMARY KEY CLUSTERED 
(
	[email_address] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cor_passwords]    Script Date: 01/31/2014 01:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cor_passwords](
	[email_address] [nvarchar](80) NOT NULL,
	[password_hash] [nvarchar](50) NOT NULL,
	[password_salt] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_cor_passwords] PRIMARY KEY CLUSTERED 
(
	[email_address] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[p_signup]    Script Date: 01/31/2014 01:37:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[p_signup] 
	-- Add the parameters for the stored procedure here
	@mod					INT=0,
	@user_name				NVARCHAR(80)='',
	@first_name				NVARCHAR(80)='',
	@last_name				NVARCHAR(80)='',
	@email_address			NVARCHAR(80)='',
	@password_hash			NVARCHAR(80)='',
	@password_salt			NVARCHAR(80)='',
	@registration_datetime	NVARCHAR(50)='0'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF(@mod=1)
		BEGIN
			INSERT INTO DBO.cor_users
						(
							[user_name]			,
							first_name			,
							last_name			,
							email_address		,
							registration_datetime
						)
			VALUES		
						(
							@user_name			,
							@first_name			,
							@last_name			,
							@email_address		,
							@registration_datetime
						)
			INSERT INTO DBO.cor_passwords
						(
							email_address,
							password_hash,
							password_salt
						)
			VALUES
						(
							@email_address,
							@password_hash,
							@password_salt
						)
			INSERT INTO dbo.cor_profile
						(
							email_address
						)
			VALUES		(
							@email_address
						)
		END
	
END
GO
/****** Object:  StoredProcedure [dbo].[p_profile]    Script Date: 01/31/2014 01:37:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[p_profile] 
	-- Add the parameters for the stored procedure here
	@mod					INT=0,
	@email_address			NVARCHAR(80)=''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF(@mod=1)
		BEGIN
			SELECT	dbo.cor_users.first_name	,
					dbo.cor_users.last_name		,
					dbo.cor_users.[user_name]	,
					CONVERT(NVARCHAR(15),dbo.cor_users.registration_datetime,103) AS registration_datetime, 
					dbo.cor_profile.cell_number	, 
					dbo.cor_profile.telephone_number,
					dbo.cor_users.email_address,
					dbo.cor_profile.[address]	, 
					dbo.cor_profile.country,
					dbo.cor_profile.province,
					dbo.cor_profile.city
			FROM	dbo.cor_users
			INNER JOIN	dbo.cor_profile
			ON		dbo.cor_users.email_address=dbo.cor_profile.email_address
			WHERE	dbo.cor_users.email_address=@email_address
		END
	
END
GO
/****** Object:  StoredProcedure [dbo].[p_login]    Script Date: 01/31/2014 01:37:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[p_login] 
	-- Add the parameters for the stored procedure here
	@mod			INT=0,
	@email_address	NVARCHAR(80)=''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF(@mod=1)
		BEGIN
			SELECT	* 
			FROM	DBO.cor_passwords
			WHERE	email_address=@email_address
		END
	
END
GO
/****** Object:  Default [DF_cor_users_registration_datetime]    Script Date: 01/31/2014 01:36:09 ******/
ALTER TABLE [dbo].[cor_users] ADD  CONSTRAINT [DF_cor_users_registration_datetime]  DEFAULT ((0)) FOR [registration_datetime]
GO
/****** Object:  ForeignKey [FK_cor_profile_cor_users]    Script Date: 01/31/2014 01:36:09 ******/
ALTER TABLE [dbo].[cor_profile]  WITH CHECK ADD  CONSTRAINT [FK_cor_profile_cor_users] FOREIGN KEY([email_address])
REFERENCES [dbo].[cor_users] ([email_address])
GO
ALTER TABLE [dbo].[cor_profile] CHECK CONSTRAINT [FK_cor_profile_cor_users]
GO
/****** Object:  ForeignKey [FK_cor_passwords_cor_users]    Script Date: 01/31/2014 01:36:09 ******/
ALTER TABLE [dbo].[cor_passwords]  WITH CHECK ADD  CONSTRAINT [FK_cor_passwords_cor_users] FOREIGN KEY([email_address])
REFERENCES [dbo].[cor_users] ([email_address])
GO
ALTER TABLE [dbo].[cor_passwords] CHECK CONSTRAINT [FK_cor_passwords_cor_users]
GO
