INSERT INTO [dbo].[Customer] VALUES
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
(1,'wifi installation3-1K','www.google.com/12354666')