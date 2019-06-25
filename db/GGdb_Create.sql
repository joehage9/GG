USE [master]
GO
/****** Object:  Database [GGdb]    Script Date: 01/04/2019 6:47:59 PM ******/
CREATE DATABASE [GGdb]
GO
ALTER DATABASE [GGdb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GGdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GGdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GGdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GGdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GGdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GGdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [GGdb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GGdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GGdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GGdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GGdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GGdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GGdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GGdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GGdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GGdb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GGdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GGdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GGdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GGdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GGdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GGdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GGdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GGdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GGdb] SET  MULTI_USER 
GO
ALTER DATABASE [GGdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GGdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GGdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GGdb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GGdb]
GO
/****** Object:  Table [dbo].[AmpereTypes]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmpereTypes](
	[Amperes] [decimal](18, 2) NOT NULL,
	[Value] [decimal](18, 2) NULL,
 CONSTRAINT [PK_AmpereTypes] PRIMARY KEY CLUSTERED 
(
	[Amperes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[AmpereNumber] [decimal](18, 2) NULL,
	[CurrentCounter] [decimal](18, 2) NULL,
	[Active] [bit] NULL,
	[Division] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[StartingCounter] [decimal](18, 2) NULL,
	[EndingCounter] [decimal](18, 2) NULL,
	[Date] [date] NULL,
	[Price] [decimal](18, 3) NULL,
	[ExtraCost] [decimal](18, 3) NULL,
	[ExtraInfo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rounding]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rounding](
	[Rounding] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarrifs]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarrifs](
	[KwhPrice] [decimal](18, 2) NULL,
	[Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerById]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerById] @id int
AS
BEGIN
	SET NOCOUNT ON;

  SELECT *
  FROM [dbo].[Customer]
  WHERE [ID] = @id

END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoicePrice]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoicePrice] @customer int, @start decimal(18, 2), @end decimal(18, 2), @date date
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @kwh decimal(18, 2) = (SELECT TOP 1 [KwhPrice] FROM [Tarrifs] WHERE @date >= [Date]);
	DECLARE @amp decimal(18, 2) = (SELECT TOP 1 [Value] FROM [AmpereTypes] INNER JOIN Customer ON [Amperes] = [Customer].[AmpereNumber] WHERE [Customer].[ID] = @customer);

	SELECT @amp + ((@end - @start) * @kwh)
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoices]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoices] @customer int
AS
BEGIN	
	SET NOCOUNT ON;

	SELECT dbo.Invoices.ID
		 , dbo.Invoices.StartingCounter
		 , dbo.Invoices.EndingCounter
		 , dbo.Invoices.Date
		 , dbo.Invoices.CustomerID
		 , dbo.Invoices.ExtraCost
		 , dbo.Invoices.ExtraInfo
		 , CustDivision = dbo.Customer.Division
		 , CustAmpPrice = dbo.AmpereTypes.Value
		 , CustAmp = dbo.Customer.AmpereNumber
		 , KWhPrice = (SELECT TOP 1 [Tarrifs].[KwhPrice] FROM [Tarrifs] WHERE [Invoices].[Date] >= [Tarrifs].[Date])
	FROM  dbo.Invoices
		  INNER JOIN dbo.Customer ON  dbo.Customer.ID = dbo.Invoices.CustomerID
	      INNER JOIN dbo.AmpereTypes ON dbo.AmpereTypes.Amperes = dbo.Customer.AmpereNumber 
	WHERE @customer	= -1 OR (@customer = dbo.Invoices.CustomerID AND dbo.Customer.Active = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoicesPrint]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoicesPrint] @ids nvarchar(MAX)
AS
BEGIN	
	SET NOCOUNT ON;
	SET @ids = ',' + @ids + ',';

	SELECT dbo.Invoices.ID
		 , dbo.Invoices.StartingCounter
		 , dbo.Invoices.EndingCounter
		 , dbo.Invoices.Date
		 , dbo.Invoices.ExtraCost
		 , dbo.Invoices.ExtraInfo
		 , CustAddress = dbo.Customer.Address
		 , CustName = dbo.Customer.FirstName + ' ' + dbo.Customer.LastName
		 , CustAmpPrice = dbo.AmpereTypes.Value
		 , CustAmp = dbo.Customer.AmpereNumber
		 , KWhPrice = (SELECT TOP 1 [Tarrifs].[KwhPrice] FROM [Tarrifs] WHERE [Invoices].[Date] >= [Tarrifs].[Date])
	FROM  dbo.Invoices
		  INNER JOIN dbo.Customer ON  dbo.Customer.ID = dbo.Invoices.CustomerID
	      INNER JOIN dbo.AmpereTypes ON dbo.AmpereTypes.Amperes = dbo.Customer.AmpereNumber 
	WHERE @ids LIKE '%,' + CAST(dbo.Invoices.ID AS nvarchar)+',%'
END
GO
/****** Object:  StoredProcedure [dbo].[SaveAmpereType]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveAmpereType] @Amperes decimal(18,2), @Value decimal(18,2)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[AmpereTypes]
           ([Amperes]
           ,[Value])
     VALUES
           (@Amperes
           ,@Value)

END
GO
/****** Object:  StoredProcedure [dbo].[SaveCustomer]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveCustomer] @id int, @first nvarchar(50), @last nvarchar(50), @mobile nvarchar(50), @address nvarchar(50), @amper decimal(18,2), @counter decimal(18,2), @active bit , @div nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	IF ((SELECT COUNT(*) FROM [dbo].[Customer] WHERE [ID] = @id) = 0)
	BEGIN
		INSERT INTO [dbo].[Customer]
			   ([FirstName]
			   ,[LastName]
			   ,[Mobile]
			   ,[Address]
			   ,[AmpereNumber]
			   ,[CurrentCounter]
			   ,[Active]
			   ,[Division])
		 VALUES
			   (@first
			   ,@last
			   ,@mobile
			   ,@address
			   ,@amper
			   ,@counter
			   ,@active
			   ,@div)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Customer]
		   SET [FirstName] = @first
			  ,[LastName] = @last
			  ,[Mobile] = @mobile
			  ,[Address] = @address
			  ,[AmpereNumber] = @amper
			  ,[CurrentCounter] = @counter
			  ,[Active] = @active
			  ,[Division] = @div
		 WHERE [ID] = @id
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SaveInvoice]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveInvoice] @id int, @customer int, @date date, @ending decimal(18,2), @starting decimal(18,2), @extracost decimal(18,3), @extrainf nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	IF ((SELECT COUNT(*) FROM [dbo].[Invoices] WHERE [ID] = @id) = 0)
	BEGIN
		IF ((SELECT COUNT(*) FROM [dbo].[Invoices] WHERE [CustomerID] = @customer AND [Date] = CONVERT(date, @date)) = 0)
		BEGIN
			INSERT INTO [dbo].[Invoices]
				   ([CustomerID]
				   ,[StartingCounter]
				   ,[EndingCounter]
				   ,[Date]
				   ,[ExtraCost]
				   ,[ExtraInfo])
			 VALUES
				   (@customer
				   ,@starting
				   ,@ending
				   ,@date
				   ,@extracost
				   ,@extrainf)

			SELECT SCOPE_IDENTITY()
		END
		ELSE
		BEGIN
			UPDATE [dbo].[Invoices]
			   SET [CustomerID] = @customer
				  ,[StartingCounter] = @starting
				  ,[EndingCounter] = @ending
				  ,[ExtraCost] = @extracost
				  ,[ExtraInfo] = @extrainf
			 WHERE [CustomerID] = @customer AND [Date] = CONVERT(date, @date)

			SELECT TOP 1 [dbo].[Invoices].[ID] FROM [dbo].[Invoices] WHERE [CustomerID] = @customer AND [Date] = CONVERT(date, @date)
		END
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Invoices]
		   SET [CustomerID] = @customer
			  ,[StartingCounter] = @starting
			  ,[EndingCounter] = @ending
			  ,[ExtraCost] = @extracost
			  ,[ExtraInfo] = @extrainf
			  ,[Date] = @date
		 WHERE [ID] = @id

		SELECT @id
	END

	UPDATE [Customer] SET [CurrentCounter] = @ending WHERE [ID] = @customer
END
GO
/****** Object:  StoredProcedure [dbo].[SaveTarrifs]    Script Date: 01/04/2019 6:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveTarrifs] @KwhPrice decimal(18,2), @RoundingValue int
AS
BEGIN
	SET NOCOUNT ON;

	IF ((SELECT COUNT(*) FROM [dbo].[Rounding]) = 0)
	BEGIN
		INSERT INTO [dbo].[Rounding]
			   ([Rounding])
		 VALUES
			   (@RoundingValue)
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Rounding]
		   SET [Rounding] = @RoundingValue
	END
	
	IF ((SELECT COUNT(*) FROM [dbo].[Tarrifs] WHERE [Date] = CONVERT(date, getdate())) = 0)
	BEGIN
		INSERT INTO [dbo].[Tarrifs]
			   ([KwhPrice], [Date])
		 VALUES
			   (@KwhPrice, CONVERT(date, DATEADD(MONTH,-1,GETDATE())))
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Tarrifs]
		   SET [KwhPrice] = @KwhPrice
		   WHERE [Date] = CONVERT(date, DATEADD(MONTH,-1,GETDATE()))

	END

END
GO
USE [master]
GO
ALTER DATABASE [GGdb] SET  READ_WRITE 
GO
