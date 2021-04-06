
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS [dbo].[Category];
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ProductId] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO
DROP TABLE IF EXISTS [dbo].[Customer];
CREATE TABLE [dbo].[Customer](
	[id] [nvarchar](100) NOT NULL,
	[UserId][int] NOT NULL,
	[AddressId] [int]NOT NULL,
	[customer_name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Product];
CREATE TABLE [dbo].[Product](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[DisplayName][nvarchar](450) NULL,
	[Description] [nvarchar](450) NULL,
	[VendorId] [int] NOT NULL,
	[CategoryId] [int] NULL,
	[ProductFormat] [nvarchar](max) NULL,
	[QuantityPerUnit] [int] NULL,
	[UnitPrice] [float] NULL,
	[UnitsInStock] [nvarchar](max) NULL,
	[Discount] [float] NULL,
	[OrderAvailable] [bit] NOT NULL,
	[ProductAvailable] [bit] NOT NULL,
	[DiscountAvailable] [bit] NOT NULL,
	[ImageId] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO
DROP TABLE IF EXISTS [dbo].[Vendor];
CREATE TABLE [dbo].[Vendor](
	[id] [int] NOT NULL,
	[vendor_name] [varchar](50) NOT NULL,
	[AddressId] [int] NULL,
	[phone_number] [varchar](50) NULL,
	[website] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[last_updatedtime] [timestamp] NULL,
	[note] [varchar](500) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Address];
CREATE TABLE [dbo].[Address](
	[id] [int] NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[Phone] [nvarchar](100) NULL,
	[Address1] [nvarchar](100) NULL,
	[Address2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Province] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[ProductAttribute];
CREATE TABLE [dbo].[ProductAttribute](
	[ProductId] [int] NOT NULL,
	[AttributeId] [int] NOT NULL,
 CONSTRAINT [PK_ProductAttribute] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Attribute];
CREATE TABLE [dbo].[Attribute](
	[id] [int] NOT NULL,
	[attribute_name] [nvarchar](200) NULL,
	[attribute_value] [nvarchar](200) NOT NULL,
	[description] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].OrderItem;
CREATE TABLE OrderItem (
    [id][nvarchar](100) NOT NULL,
	[OrderId][nvarchar](100) NOT NULL,
	[ProductId][int] NOT NULL,
    [Quantity] decimal(8, 2),
    Unit nvarchar(10),
    PriceUnit money,
    Price money,
    CreatedAt datetimeoffset(7),
    UpdatedAt datetimeoffset(7),
	CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Order];
CREATE TABLE [dbo].[Order] (
    [id] [nvarchar](100) NOT NULL,
	[CustomerId] [nvarchar](100) NOT NULL,
    [Status] nvarchar(1),
    RequiredDate Date,
    Comment nvarchar(200),
    CreatedAt datetimeoffset(7),
    UpdatedAt datetimeoffset(7),
	CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Cart];
CREATE TABLE [dbo].[Cart](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreatedDate] datetimeoffset(7) NOT NULL,
	CONSTRAINT Cart_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_Cart PRIMARY KEY(Id)
);
GO
DROP TABLE IF EXISTS [dbo].[CartItem];
CREATE TABLE [dbo].[CartItem](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CartId] [int],
	CreatedDate datetimeoffset(7),
	CONSTRAINT CartItem_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_CartItem PRIMARY KEY(Id),
);
GO
DROP TABLE IF EXISTS [dbo].[Invoice];
CREATE TABLE [dbo].[Invoice](
	[Id] [int]  IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](100) NOT NULL,
	[CustomerId] [nvarchar](100) NULL,
	[Date] datetimeoffset(7) NOT NULL,
    [SubTotal] [decimal] NOT NULL,
	[ShippingTotal] [decimal] NULL, 
    [Total] [decimal](18) NULL,
    [ShippingToId] [nvarchar](255) NOT NULL,
	[BillingToId] [nvarchar](255) NOT NULL
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Payment];
CREATE TABLE [dbo].[Payment](
	[Id] [nvarchar](255) NOT NULL,
	[InvoiceId] [nvarchar](255) NOT NULL,	
	[PaymentMethodId] [nvarchar](255) NOT NULL,
	[Date] datetimeoffset(7) NOT NULL,
	[Status] [nvarchar](255) NOT NULL,
	[TransactionType] [nvarchar](255) NOT NULL

 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO
DROP TABLE IF EXISTS [dbo].[PaymentMethod];
CREATE TABLE [dbo].[PaymentMethod](
	[Id] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[TrnCode] [nvarchar](255) NOT NULL,
	[MethodCode] [varchar](2) NOT NULL,

 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Shipments];
CREATE TABLE [dbo].[Shipments](
	[Id] [nvarchar](100) NOT NULL,
	[OrderId] [nvarchar](100) NOT NULL,
	[TrackingNumber] [nvarchar](450) NULL,
	[WarehouseId] [int] NULL,
	[VendorId] [int] NULL,
	[CreatedDate] datetimeoffset(7),
	[LatestUpdatedDate] datetimeoffset(7),
	[Description][nVarchar](450)
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Warehouse];
CREATE TABLE [dbo].[Warehouse](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[AddressId] [nvarchar](450) NULL,
	[VendorId] [INT] NULL,
	[Description][nVarchar](100)
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[AppSetting];
CREATE TABLE [dbo].[AppSetting](
	[Id] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](450) NULL,
	[Module] [nvarchar](450) NULL,
	[IsVisibleInCommonSettingPage] [bit] NOT NULL,
	[Description][nVarchar](450)
 CONSTRAINT [PK_Core_AppSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

