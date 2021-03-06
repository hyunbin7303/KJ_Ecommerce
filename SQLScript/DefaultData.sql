USE [MainEcommerceDB]
GO
INSERT INTO [dbo].[Category]([Name], [ProductId])VALUES('Example Category', null)

select * from Category


GO
INSERT INTO [dbo].[Vendor]([Id], [vendor_name], [AddressId], [phone_number], [website], [email], [last_updatedtime], [note])VALUES(1, 'Habib Vendor', null, null, null, null, null, null)
INSERT INTO [dbo].[Vendor]([Id], [vendor_name], [AddressId], [phone_number], [website], [email], [last_updatedtime], [note])VALUES(2, 'Hyunbin Vendor', null, null, null, null, null, null)
INSERT INTO [dbo].[Vendor]([Id], [vendor_name], [AddressId], [phone_number], [website], [email], [last_updatedtime], [note])VALUES(3, 'Kevin Vendor', null, null, null, null, null, null)
INSERT INTO [dbo].[Vendor]([Id], [vendor_name], [AddressId], [phone_number], [website], [email], [last_updatedtime], [note])VALUES(4, 'Evan Vendor', null, null, null, null, null, null)
INSERT INTO [dbo].[Vendor]([Id], [vendor_name], [AddressId], [phone_number], [website], [email], [last_updatedtime], [note])VALUES(5, 'Julio Vendor', null, null, null, null, null, null)

GO
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(1,'Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Basic',			1,	100,		'True',		0.10, 1, 1, 1,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(2,'Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Normal',			1,	115,		'True',		null, 1, 1, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(3,'Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Full',			1,	130,		'True',		null, 1, 1, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(4,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Basic',			1,	120,		'True',		null, 1, 1, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(5,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Normal',			1,	150,		'True',		0.15, 1, 1, 1,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(6,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Full',			1,	170,		'False',	null, 0, 0, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(7,'Lord of the Ring - fellowship',	'Lord of the Ring - fellowship Book',	'LOTR soft copy',									2, null, 'Soft Copy',		2,	30,			'False',	null, 0, 0, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(8,'To Kill A Mocking Bird', 			'To Kill A Mocking Bird book',			'TKAMB hard copy',									2, null, 'Hard Copy',		4,	40.99,		'True',		0.30, 1, 1, 1,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(9,'Coke - Pack#1',					'6 Pack of Coca Cola',					'Pack of Coca Cola',								3, null, 'Warehouse Item',	1,	7.50,		'True',		null, 1, 1, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(10,'Ginger Ale',						'6 Pack of Ginger Ale',					'Pack of Ginger Ale',								3, null, 'Warehouse Item',	1,	6.50,		'True',		null, 1, 1, 0,	NULL,NULL)																																				    
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(11,'Necklace',						'Cross Necklace',						'Sterling Silver Thin 0.6mm Box Chain Necklace',	4, null, 'Warehouse Item',	3,	19,			'False',	null, 0, 0, 0,	NULL,NULL)
INSERT INTO [dbo].[Product]([Id], [Name], [DisplayName], [Description], [VendorId], [CategoryId], [ProductFormat], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [Discount], [OrderAvailable], [ProductAvailable], [DiscountAvailable], [ImageId], [Note])VALUES(12,'Hot Wheels Car',					'Fast and Furios Paul Walker Car',		'Hot wheels R/C 1:64 Mini Nissan Skyline',			5, null, 'Warehouse Item',	5,	13,			'True',		null, 1, 1, 0,	NULL,NULL)		

GO
INSERT INTO [dbo].[Address] VALUES
(1,'Habib Shakibanejad', '222-123-1234', '534 Main St.', 'Kitchener', 'Ontario','Canada'),
(2,'Julio Rivas', '456-123-1253', '534 Main St.', 'Kitchener', 'Ontario','Canada'),
(3,'Kevin Park', '234-754-4234', '4 Old Mill Rd.', 'Waterloo', 'Ontario','Canada'),
(4,'Evan', '867-456-3472', '6412 Westrood Rd.', 'Guelph', 'Ontario','Canada'),
(5,'Michael Jackson', '876-786-7375', '2355 Cresthaven St.', 'Toronto', 'Ontario','Canada'),
(6,'Roosie McDonald', '769-456-4565', '87 Orchard Mill Rd.', 'Ottawa', 'Ontario','Canada'),
(7,'Client Eastwood', '656-456-4554', '48 Booth St.', 'Kitchener', 'Cambridge','Canada')

GO
INSERT INTO [dbo].[Customer] VALUES 
('1',1,1,'Habib Shakibanejad',null),
('2',2,2,'Julio Rivas',null),
('3',3,3,'Kevin Park',null),
('4',4,4,'Evan',null),
('5',5,5,'Michael Jackson',null),
('6',6,6,'Chris Tucker',null)

GO
INSERT INTO [dbo].Cart VALUES
('1',1,GETDATE()-1),
('2',2,GETDATE()-2),
('3',3,GETDATE()-3),
('4',4,GETDATE()-4),
('5',5,GETDATE()-5),
('6',6,GETDATE()-6)


INSERT INTO [dbo].[Image] VALUES
(1,1,'wifi installation','www.google.com'),
(2,1,'wifi installation2','www.google.com/12354'),
(3,1,'wifi installation2-1','www.google.com/12357774'),
(4,1,'wifi installation3-1K','www.google.com/12354666')

