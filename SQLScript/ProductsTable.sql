USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 2021-03-29 9:59:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[SupplierId] [int] NOT NULL,
	[CustomerId] [nvarchar](max) NULL,
	[ProductFormat] [nvarchar](max) NULL,
	[QuantityPerUnit] [int] NULL,
	[UnitPrice] [float] NULL,
	[UnitsInStock] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[ImageAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


