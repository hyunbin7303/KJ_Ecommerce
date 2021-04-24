
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
	[Id] [nvarchar](100) NOT NULL,
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[AttributeId] [int] NOT NULL,
 CONSTRAINT [PK_ProductAttribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Attribute];
CREATE TABLE [dbo].[Attribute](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[attribute_name] [nvarchar](200) NULL,
	[attribute_value] [nvarchar](200) NOT NULL,
	[description] [nvarchar](200) NOT NULL
 CONSTRAINT [PK_Attribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

GO
DROP TABLE IF EXISTS [dbo].OrderItem;
CREATE TABLE OrderItem (
    [id][nvarchar](100) NOT NULL, 
    [OrderId][nvarchar](100) NOT NULL,
    [ProductId][int] NOT NULL,
    [Quantity] decimal(8, 2),
    UnitPrice [decimal](18,2) NULL,
    TotalPrice  [decimal](18,2) NULL,
    Discount [decimal](18,2) NULL,
    CreatedDate datetimeoffset(7),
    UpdatedDate datetimeoffset(7),
    CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Order];
CREATE TABLE [dbo].[Order] (
    [Id] [nvarchar](100) NOT NULL,
    [CustomerId] [nvarchar](100) NOT NULL,
    [VendorId][int] NULL,
    [CartId][nvarchar](100) NULL,
    [Status] nvarchar(1),
    Comment nvarchar(200),
    RequiredDate datetimeoffset(7),
    CreatedDate datetimeoffset(7),
    UpdatedDate datetimeoffset(7),
	CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Cart];
CREATE TABLE [dbo].[Cart](
	[Id] [nvarchar](100) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreatedDate] datetimeoffset(7) NOT NULL,
	CONSTRAINT Cart_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_Cart PRIMARY KEY(Id)
);
GO
DROP TABLE IF EXISTS [dbo].[CartItem];
CREATE TABLE [dbo].[CartItem](
	[Id] [nvarchar](100) NOT NULL,
	[CartId] [nvarchar](100) NULL,
	[ProductId] [int],
	[Quantity] decimal(8, 2),
	CreatedDate datetimeoffset(7),
	CONSTRAINT CartItem_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_CartItem PRIMARY KEY(Id),
);
GO
DROP TABLE IF EXISTS [dbo].[Invoice];
CREATE TABLE [dbo].[Invoice](
	[Id] [nvarchar](100) NOT NULL,
	[OrderId] [nvarchar](100) NOT NULL,
	[CustomerId] [nvarchar](100) NULL,
	[ShipmentId] [nvarchar](100) NOT NULL,
	[PaymentId] [nvarchar](100) NOT NULL,
	[Date] datetimeoffset(7) NOT NULL,
        [SubTotal] [decimal](18,2) NOT NULL,
	[ShippingTotal] [decimal](18,2) NULL, 
	[VAT][decimal](18,2) NULL, -- Value-Added Tax. 
        [Total] [decimal](18,2) NULL,
	[CustomerNote] [nvarchar](1000) NULL,

 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Payment];
CREATE TABLE [dbo].[Payment](
	[Id] [nvarchar](100) NOT NULL,
	[InvoiceId] [nvarchar](100) NULL,	
	[PaymentMethodId] [int] NOT NULL,
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[TrnCode] [nvarchar](255) NOT NULL,
	[MethodCode] [varchar](2) NOT NULL,

 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Shipment];
CREATE TABLE [dbo].[Shipment](
	[Id] [nvarchar](100) NOT NULL,
	[TrackingNumber] [nvarchar](450) NULL,
	[AddressId] [int] NULL,
	[WarehouseId] [int] NULL,
	[VendorId] [int] NULL,
	[CreatedDate] datetimeoffset(7),
	[LatestUpdatedDate] datetimeoffset(7),
	[QuantityShipped] [int] NULL,
	[Description][nVarchar](450)
	--Carrier Id.
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [dbo].[Warehouse];
CREATE TABLE [dbo].[Warehouse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
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

DROP TABLE IF EXISTS [dbo].[ProductReview];
CREATE TABLE [dbo].[ProductReview](
	[Id] [nvarchar](100) NOT NULL,
	[CustomerId] [nvarchar](100) NOT NULL,
	[Rating] [int] NOT NULL,
	[CreatedDate] datetimeoffset(7),
	[Title][nVarchar](100) NULL,
	[Comment][nVarchar](450) NULL,
 CONSTRAINT [PK_ProductReview] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP TABLE IF EXISTS [dbo].[AppSetting];
CREATE TABLE [dbo].[AppSetting](
	[Id] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](300) NULL,
	[Module] [nvarchar](300) NULL,
	[IsVisibleInCommonSettingPage] [bit] NOT NULL,
	[Description][nVarchar](450)
 CONSTRAINT [PK_AppSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

DROP TABLE IF EXISTS [dbo].[App_Menu];
CREATE TABLE [dbo].[App_Menu](
	[Id] [nvarchar](200) NOT NULL,
	[UsedBy][nvarchar](100) NULL,
	[ParentId] [nvarchar](200) NULL,
	[MenuName] [nvarchar](300) NULL,
	[MenuType] [varchar](4) NULL,
	[Visibility][nvarchar](20) NULL,
	[Availability][nvarchar](20) NULL,
	[LatestUpdatedDate] datetimeoffset(7),
	[Description][nVarchar](450)
 CONSTRAINT [PK_App_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


DROP TABLE IF EXISTS [dbo].[Image];
CREATE TABLE [dbo].[Image](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId][int] NOT NULL,
	[ImageTitle] [nvarchar](100) NULL,
	[ImageURL] [nvarchar](450) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




ALTER TABLE [OrderItem] ADD CONSTRAINT FK_OrderId FOREIGN KEY (OrderId) REFERENCES [Order](id);
ALTER TABLE [OrderItem] ADD CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES [Product](id);
ALTER TABLE [Product]   ADD CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES [Category](id);
ALTER TABLE [Product]   ADD CONSTRAINT FK_VendorId FOREIGN KEY   (VendorId) REFERENCES [Vendor](id);
ALTER TABLE [CartItem]   ADD CONSTRAINT FK_CartId FOREIGN KEY   (CartId) REFERENCES [Cart](id);
ALTER TABLE [Payment]   ADD CONSTRAINT FK_PaymentMethodId FOREIGN KEY   (PaymentMethodId) REFERENCES [PaymentMethod](id);
ALTER TABLE [ProductAttribute]   ADD CONSTRAINT FK_ProductAttribute_ProudctId FOREIGN KEY   (ProductId) REFERENCES [Product](id);
ALTER TABLE [ProductAttribute]   ADD CONSTRAINT FK_ProductAttribute_AttributeId FOREIGN KEY (AttributeId) REFERENCES [Attribute](id);




