<#
param(
        [Parameter(Mandatory=$true)]
        [System.String]
        $SqlInstance
     )
#>

# Set-ExecutionPolicy and change the Execution Policy setting
# Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass
# Install-Module dbatools;

$SqlInstance = "(localdb)\MSSQLLocalDB"
$Database = "MainEcommerceDB"

<# Message 
Pause "This script will remove all objects from database [$Database] on SQL Server Instance: [$SqlInstance]. **** Press CTRL+c to sop now ****";
#>

#---------------------------
#Get the SMO object tree
#---------------------------
$DatabaseSMO = Get-DbaDatabase -SqlInstance $SqlInstance -Database $Database;

<#
#Drop all the tables. Loop is to keep retrying on tables that could not be dropped due to FK's.
$SqlInstance = "(localdb)\MSSQLLocalDB"
$Database = "MainEcommerceDB"
$DatabaseSMO = Get-DbaDatabase -SqlInstance $SqlInstance -Database $Database;

while(1 -eq 1)
{
    $tablesArray = $DatabaseSMO.Tables | Select-Object Schema,Name;
 
    if ($tablesArray.Count -eq 0)
    {
        break;
    }
 
    foreach($table in $tablesArray)
    {
        Write-Host("About to drop table $($table.Schema).$($table.name)");
        Invoke-DbaQuery -SqlInstance $SqlInstance -Database $Database -Query "DROP TABLE [$($table.Schema)].[$($table.name)]";
    }
 
    $DatabaseSMO.Tables.Refresh();
}
#>

$query = "
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Customer];
CREATE TABLE [MainEcommerceDB].[dbo].[Customer](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Address];
CREATE TABLE [MainEcommerceDB].[dbo].[Address](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[ProductAttribute];
CREATE TABLE [MainEcommerceDB].[dbo].[ProductAttribute](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[AttributeId] [int] NOT NULL,
 CONSTRAINT [PK_ProductAttribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Attribute];
CREATE TABLE [MainEcommerceDB].[dbo].[Attribute](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[OrderItem];
CREATE TABLE [MainEcommerceDB].[dbo].[OrderItem] (
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[CartItem];
CREATE TABLE [MainEcommerceDB].[dbo].[CartItem](
	[Id] [nvarchar](100) NOT NULL,
	[CartId] [nvarchar](100) NULL,
	[ProductId] [int],
	[Quantity] decimal(8, 2),
	[UnitPrice] decimal(8, 2),
	[CreatedDate] datetimeoffset(7),
	CONSTRAINT CartItem_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_CartItem PRIMARY KEY(Id),
);
GO
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Cart];
CREATE TABLE [MainEcommerceDB].[dbo].[Cart](
	[Id] [nvarchar](100) NOT NULL,
	[VendorId][int] NOT NULL,
	[CustomerId] [nvarchar](100) NOT NULL,
	[CreatedDate] datetimeoffset(7) NOT NULL,
	CONSTRAINT Cart_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_Cart PRIMARY KEY(Id)
);
GO
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Invoice];
CREATE TABLE [MainEcommerceDB].[dbo].[Invoice](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Payment];
CREATE TABLE [MainEcommerceDB].[dbo].[Payment](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[PaymentMethod];
CREATE TABLE [MainEcommerceDB].[dbo].[PaymentMethod](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Shipment];
CREATE TABLE [MainEcommerceDB].[dbo].[Shipment](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Warehouse];
CREATE TABLE [MainEcommerceDB].[dbo].[Warehouse](
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

DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[ProductReview];
CREATE TABLE [MainEcommerceDB].[dbo].[ProductReview](
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

DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[AppSetting];
CREATE TABLE [MainEcommerceDB].[dbo].[AppSetting](
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

DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[App_Menu];
CREATE TABLE [MainEcommerceDB].[dbo].[App_Menu](
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


DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Image];
CREATE TABLE [MainEcommerceDB].[dbo].[Image](
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

DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Order];
CREATE TABLE [MainEcommerceDB].[dbo].[Order] (
    [Id] [nvarchar](100) NOT NULL,
    [CustomerId] [nvarchar](100) NOT NULL,
    [VendorId][int] NULL,
    [CartId][nvarchar](100) NULL,
    [Status] nvarchar(2),
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Product];
CREATE TABLE [MainEcommerceDB].[dbo].[Product](
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
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Vendor];
CREATE TABLE [MainEcommerceDB].[dbo].[Vendor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[vendor_name] [varchar](50) NOT NULL,
	[AddressId] [int] NULL,
	[phone_number] [varchar](50) NULL,
	[website] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[note] [varchar](500) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
DROP TABLE IF EXISTS [MainEcommerceDB].[dbo].[Category];
CREATE TABLE [MainEcommerceDB].[dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Active] [bit] NOT NULL
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO

ALTER TABLE [MainEcommerceDB].[dbo].[OrderItem] ADD CONSTRAINT FK_OrderId FOREIGN KEY (OrderId) REFERENCES [Order](id);
ALTER TABLE [MainEcommerceDB].[dbo].[OrderItem] ADD CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES [Product](id);
ALTER TABLE [MainEcommerceDB].[dbo].[Product] ADD CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES [Category](id);
ALTER TABLE [MainEcommerceDB].[dbo].[Product] ADD CONSTRAINT FK_VendorId FOREIGN KEY (VendorId) REFERENCES [Vendor](id);
ALTER TABLE [MainEcommerceDB].[dbo].[CartItem] ADD CONSTRAINT FK_CartId FOREIGN KEY (CartId) REFERENCES [Cart](id);
ALTER TABLE [MainEcommerceDB].[dbo].[Payment] ADD CONSTRAINT FK_PaymentMethodId FOREIGN KEY (PaymentMethodId) REFERENCES [PaymentMethod](id);
ALTER TABLE [MainEcommerceDB].[dbo].[ProductAttribute] ADD CONSTRAINT FK_ProductAttribute_ProudctId FOREIGN KEY (ProductId) REFERENCES [Product](id);
ALTER TABLE [MainEcommerceDB].[dbo].[ProductAttribute] ADD CONSTRAINT FK_ProductAttribute_AttributeId FOREIGN KEY (AttributeId) REFERENCES [Attribute](id);
ALTER TABLE [MainEcommerceDB].[dbo].[Category]  ADD CONSTRAINT [DF_Categoryg_Active]  DEFAULT ((1)) FOR [Active]
"

# Generate data
Invoke-Sqlcmd -query $query -ServerInstance $SqlInstance

$query = "

INSERT INTO [MainEcommerceDB].[dbo].[Customer] VALUES
('habib0303',1,1,'Habib Shakibanejad',null),
('julio1927',2,2,'Julio Rivas',null),
('kevin7303',3,3,'Kevin Park',null),
('4',4,4,'Evan',null),
('5',5,5,'Michael Jackson',null),
('Evan1234',6,6,'Chris Tucker',null)

INSERT INTO [MainEcommerceDB].[dbo].[Vendor] VALUES
('Vendor01',7,'123-4567-1234','hyunbin7303@hb.com','hyunbin7303@gmail.com','Hyunbin Clinet vendor'),
('kevin''s store',8,'123-4567-1234','asdf@hb.com','h12321321@gmail.com','kevins vendor store'),
('Julio Restaurant',9,'555-6666-1234','bbbbbaaa@hb.com','hasdfdsafsda303@gmail.com','Haaaa')

INSERT INTO [MainEcommerceDB].[dbo].[Cart]
(id, VendorId, CustomerId, CreatedDate) VALUES
('981D835A-A255-4CF5-B868-FCB054326A97',1,'Evan1234',GETDATE()-1),
('F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A',2,'Evan1234',CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('CE79A63C-20CC-427C-B632-E05E19A45895',3,'julio1927',GETDATE()-3),
('F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE',1,'kevin7303',GETDATE()-4),
('0C1A3BC8-17F4-4DC6-85A7-042E509560C2',2,'kevin7303',GETDATE()-5),
('0B3EEB90-87D3-4093-832F-E122B3DA778E',3,'julio1927',GETDATE()-6),
('C0E48D99-4C13-44F8-B8AE-1DBE0ABBE4F5',1,'julio1927',GETDATE()-7),
('72F75054-669A-44A6-88BC-144E4A3F72B3',2,'julio1927',GETDATE()-8),
('B79D641B-A39E-4B43-8FA2-81BB6D1D733E',3,'julio1927',GETDATE()-9)

INSERT INTO [MainEcommerceDB].[dbo].[CartItem] VALUES
('4D30F537-CA8C-43D9-ADE3-AE8421A4E920','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('B1AAFACC-0A5C-4090-B0E5-36446F861627','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('F5588E00-62BA-4A50-9EC0-36E55A6EF76A','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('AE0A0E8D-7548-49F3-81BB-8E2C1F5885EF','CE79A63C-20CC-427C-B632-E05E19A45895',1,2,170.10,GETDATE()),
('AEDF19D8-6FFC-4CA1-883F-5E1837107C04','F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE',1,2,170.10,GETDATE())

INSERT INTO [MainEcommerceDB].[dbo].[Category]([Name]) VALUES
('Desktop Computers'),
('Monitors'),
('Printers'),
('Keyboard'),
('Mouse'),
('Networking'),
('Smart Security'),
('Cables'),
('Headsets'),
('Speakers'),
('Adapter & Chargers'),
('Security & Surveillance'),
('Laptop & Tablet Accessories'),
('Home & Office Furnitures'),
('Bundle Gift Items'),
('Batteries'),
('Bags & Cases')

INSERT INTO [MainEcommerceDB].[dbo].[Product] VALUES
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, 6, 'Basic',			1,	100,		'True',		0.10, 1, 1, 1,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, 6, 'Normal',			1,	115,		'True',		null, 1, 1, 0,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, 6, 'Full',			1,	130,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, 6, 'Basic',			1,	120,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, 6, 'Normal',			1,	150,		'True',		0.15, 1, 1, 1,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, 6, 'Full',			1,	170,		'False',	null, 0, 0, 0,	NULL,NULL),
('Lord of the Ring - fellowship',	'Lord of the Ring - fellowship Book',	'LOTR soft copy',									2, 7, 'Soft Copy',		2,	30,			'False',	null, 0, 0, 0,	NULL,NULL),
('To Kill A Mocking Bird', 			'To Kill A Mocking Bird book',			'TKAMB hard copy',									2, 8, 'Hard Copy',		4,	40.99,		'True',		0.30, 1, 1, 1,	NULL,NULL),
('Coke - Pack#1',					'6 Pack of Coca Cola',					'Pack of Coca Cola',								3, 9, 'Warehouse Item',	1,	7.50,		'True',		null, 1, 1, 0,	NULL,NULL),
('Ginger Ale',						'6 Pack of Ginger Ale',					'Pack of Ginger Ale',								3, 10, 'Warehouse Item',	1,	6.50,		'True',		null, 1, 1, 0,	NULL,NULL),																																				    
('Necklace',						'Cross Necklace',						'Sterling Silver Thin 0.6mm Box Chain Necklace',	1, 11, 'Warehouse Item',	3,	19,			'False',	null, 0, 0, 0,	NULL,NULL),
('Hot Wheels Car',					'Fast and Furios Paul Walker Car',		'Hot wheels R/C 1:64 Mini Nissan Skyline',			1, 12, 'Warehouse Item',	5,	13,			'True',		null, 1, 1, 0,	NULL,NULL)

INSERT INTO [MainEcommerceDB].[dbo].[Order]
(id, CustomerId, VendorId, CartId, Status, Comment, RequiredDate, CreatedDate, UpdatedDate) VALUES
('981D835A-8344-454E-AE6E-CF3511C81701','320B0B38-8344-454E-AE6E-CF3511C81701',1,'981D835A-A255-4CF5-B868-FCB054326A97','R','COMMENT',CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-22 12:35:00.0000' AS datetimeoffset(7))),
('981D835A-8344-454E-AE6E-CF3511C81702','320B0B38-8344-454E-AE6E-CF3511C81702',2,'F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A','S','COMMENT',CAST('2021-04-22 14:35:29.1234' AS datetimeoffset(7)),CAST('2007-05-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('981D835A-8344-454E-AE6E-CF3511C81703','320B0B38-8344-454E-AE6E-CF3511C81703',3,'CE79A63C-20CC-427C-B632-E05E19A45895','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-15 12:35:29.1234' AS datetimeoffset(7))),
('981D835A-8344-454E-AE6E-CF3511C81704','320B0B38-8344-454E-AE6E-CF3511C81704',1,'F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('981D835A-8344-454E-AE6E-CF3511C81705','320B0B38-8344-454E-AE6E-CF3511C81705',2,'0C1A3BC8-17F4-4DC6-85A7-042E509560C2','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('981D835A-8344-454E-AE6E-CF3511C81706','320B0B38-8344-454E-AE6E-CF3511C81706',3,'0B3EEB90-87D3-4093-832F-E122B3DA778E','R','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7)))

INSERT INTO [MainEcommerceDB].[dbo].[OrderItem]
(id, OrderId, ProductId, Quantity, UnitPrice, TotalPrice, Discount, CreatedDate) VALUES
('FA403181-A1FE-4AB3-8172-43CBDE66E701','981D835A-8344-454E-AE6E-CF3511C81701',1,2,100,200,0,GETDATE()),
('FA403181-A1FE-4AB3-8172-43CBDE66E702','981D835A-8344-454E-AE6E-CF3511C81701',4,4,120,480,0,GETDATE()),
('FA403181-A1FE-4AB3-8172-43CBDE66E703','981D835A-8344-454E-AE6E-CF3511C81703',6,6,170,1020,0,GETDATE()),
('FA403181-A1FE-4AB3-8172-43CBDE66E704','981D835A-8344-454E-AE6E-CF3511C81704',9,4,7.50,30,0,GETDATE())

INSERT INTO [MainEcommerceDB].[dbo].[Address] VALUES
('Habib Shakibanejad',		'222-123-1234', '534 Main St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
('Julio Rivas',				'456-123-1253', '534 Main St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
('Kevin Park',				'234-754-4234', '4 Old Mill Rd.',		'','Waterloo',		'Ontario',	'Canada',NULL),
('Evan',					'867-456-3472', '6412 Westrood Rd.',	'','Guelph',		'Ontario',	'Canada',NULL),
('Michael Jackson',			'876-786-7375', '2355 Cresthaven St.',	'','Toronto',		'Ontario',	'Canada',NULL),
('Roosie McDonald',			'769-456-4565', '87 Orchard Mill Rd.',	'','Ottawa',		'Ontario',	'Canada',NULL),
('Client Eastwood',			'656-456-4554', '48 Booth St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
('hyunbin park Vendor01',	'519-721-5349',	'258 haha my name',		'','Waterloo',		'Ontario',	'Canada',NULL),
('Habib Vendor store',		'656-456-4554', '48 Booth St.',			'','Kitchener',		'Ontario',	'Canada',NULL)

INSERT INTO [MainEcommerceDB].[dbo].[Image] VALUES
(1,'wifi installation','www.google.com'),
(1,'wifi installation2','www.google.com/12354'),
(1,'wifi installation2-1','www.google.com/12357774'),
(1,'wifi installation3-1K','www.google.com/12354666')"

Invoke-Sqlcmd -query $query -ServerInstance $SqlInstance
