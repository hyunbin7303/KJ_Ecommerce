use [MainEcommerceDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](200),
	[Customer] [nvarchar](50) NULL,
	[ProductFormat] [nvarchar](50) NULL,
	[QuantityPerUnit] [int] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
	[UnitsInStock] [nvarchar](10) NULL,
	[CategoryId] [int] NULL,
	[ImageAddress][nvarchar](100) NULL,
	[Note][nvarchar](200) Null,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 2021-02-12 5:18:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER SCHEMA NewSchema TRANSFER [OldSchema].[TableName]
Go
alter schema Discount TRANSFER dbo.Products
Go

