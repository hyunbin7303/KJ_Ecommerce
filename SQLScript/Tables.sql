USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 2021-03-29 10:05:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ProductId] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 2021-03-29 10:04:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[id] [nvarchar](450) NOT NULL,
	[user_id][int] NOT NULL,
	[customer_name] [nvarchar](100) NOT NULL,
	[address_id] [int]NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Products]    Script Date: 2021-03-29 9:59:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NULL,
	[DisplayName][nvarchar](450) NULL,
	[Description] [nvarchar](450) NULL,
	[VendorId] [int] NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[ProductFormat] [nvarchar](max) NULL,
	[QuantityPerUnit] [int] NULL,
	[UnitPrice] [float] NULL,
	[UnitsInStock] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[Discount] [float] NULL,
	[OrderAvailable] [bit] NOT NULL,
	[ProductAvailable] [bit] NOT NULL,
	[DiscountAvailable] [bit] NOT NULL,
	[ImageAddress] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO




/****** Object:  Table [dbo].[Vendor]    Script Date: 2021-04-03 3:19:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vendor](
	[id] [int] NOT NULL,
	[vendor_name] [varchar](50) NOT NULL,
	[address_id] [int] NULL,
	[phone_number] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[website] [varchar](50) NULL,
	[last_updatedtime] [timestamp] NULL,
	[note] [varchar](500) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Address](
	[id] [int] NOT NULL,
	[CAontactName] [nvarchar](100) NULL,
	[Phone] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[ProductAttribute](
	[product_id] [int] NOT NULL,
	[attribute_id] [int] NOT NULL,
 CONSTRAINT [PK_ProductAttribute] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Attribute](
	[id] [int] NOT NULL,
	[attribute_name] [nvarchar](200) NULL,
	[attribute_value] [nvarchar](200) NOT NULL,
	[description] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO

