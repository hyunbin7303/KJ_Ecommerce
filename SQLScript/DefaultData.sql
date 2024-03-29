INSERT INTO [dbo].[Customer] VALUES
('habib0303',		1,	1,	'Habib Shakibanejad',	'Customer Description'),
('julio1927',		2,	2,	'Julio Rivas',			null),
('kevin7303',		3,	3,	'Kevin Park',			null),
('4',				4,	4,	'Evan',					null),
('5',				5,	5,	'Michael Jackson',		null),
('Evan1234',		6,	6,	'Chris Tucker',			null),
('CustomerID01',	7,	6,	'AZZZZZZa',				'Customer Description'),
('CustomerID02',	7,	6,	'AZZZZZZab',			''),
('CustomerID03',	7,	6,	'AZZZZZZac',			''),
('CustomerID04',	7,	6,	'AZZZZZZad',			''),
('CustomerID05',	7,	6,	'AZZZZZZae',			'')

INSERT INTO [MainEcommerceDB].[dbo].[Vendor] VALUES
('VendorCheck',			1,	'123-555-9999',		'hyunbin7303@hb.com',	'hyunbin7303@gmail.com','Vendor App'),
('Vendor01',			7,	'123-4567-1234',	'hyunbin7303@hb.com',	'hyunbin7303@gmail.com','Hyunbin Clinet vendor'),
('kevin''s store',		8,	'123-4567-1234',	'asdf@hb.com',			'h12321321@gmail.com','kevins vendor store'),
('Julio Restaurant',	9,	'555-6666-1234',	'bbbbbaaa@hb.com',		'hasdfdsafsda303@gmail.com','Haaaa'),
('IT Discuss',			7,	'123-4567-5555',	'hyunbin7303@hb.com',	'hyunbin7303@gmail.com',		'IT Consaltant company'),
('kevin''s store',		8,	'123-4567-1234',	'asdf@hb.com',			'h12321321@gmail.com',			'kevins vendor store'),
('Julio Restaurant',	9,	'555-6666-1234',	'bbbbbaaa@hb.com',		'hasdfdsafsda303@gmail.com',	'Haaaa'),
('Shoes shop',			12,	'555-1234-1555',	'werwer@hb.com',		'hasdfdsafsda303@gmail.com',	'Haaaa'),
('Shoes shop#2',		12,	'555-1234-1555',	'werwer@hb.com',		'hasdfdsafsda303@gmail.com',	'Haaaa'),
('Shoes shop#3',		12,	'555-1234-1555',	'werwer@hb.com',		'hasdfdsafsda303@gmail.com',	'Haaaa'),
('Book Store',			12,	'555-1234-1555',	'werwer@hb.com',		'hasdfdsafsda303@gmail.com',	'Book Store.')

INSERT INTO [MainEcommerceDB].[dbo].[Cart]
(id, VendorId, CustomerId,CartActive, CartLocked, CartStatus, CartType,TotalPrice, CreatedDate) VALUES
('981D835A-A255-4CF5-B868-FCB054326A97',1,'Evan1234',	1,0,'Normal','',NULL,GETDATE()-1),
('F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A',2,'Evan1234',	1,0,'Normal','',NULL,CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('CE79A63C-20CC-427C-B632-E05E19A45895',3,'julio1927',	1,0,'Normal','',NULL,GETDATE()-3),
('F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE',1,'kevin7303',	1,0,'Normal','',NULL,GETDATE()-4),
('0C1A3BC8-17F4-4DC6-85A7-042E509560C2',2,'kevin7303',	1,0,'Normal','',NULL,GETDATE()-5),
('0B3EEB90-87D3-4093-832F-E122B3DA778E',3,'julio1927',	1,0,'Normal','',NULL,GETDATE()-6),
('C0E48D99-4C13-44F8-B8AE-1DBE0ABBE4F5',1,'julio1927',	1,0,'Normal','',NULL,GETDATE()-7),
('72F75054-669A-44A6-88BC-144E4A3F72B3',2,'julio1927',	1,0,'Normal','',NULL,GETDATE()-8),
('B79D641B-A39E-4B43-8FA2-81BB6D1D733E',3,'julio1927',	1,0,'Normal','',NULL,GETDATE()-9)

INSERT INTO [MainEcommerceDB].[dbo].[CartItem] VALUES
('4D30F537-CA8C-43D9-ADE3-AE8421A4E920','981D835A-A255-4CF5-B868-FCB054326A97',1,NULL,2,170.10,GETDATE(), GetDATE()),
('B1AAFACC-0A5C-4090-B0E5-36446F861627','981D835A-A255-4CF5-B868-FCB054326A97',1,NULL,2,170.10,GETDATE(), GetDATE()),
('F5588E00-62BA-4A50-9EC0-36E55A6EF76A','981D835A-A255-4CF5-B868-FCB054326A97',1,NULL,2,170.10,GETDATE(), GetDATE()),
('AE0A0E8D-7548-49F3-81BB-8E2C1F5885EF','CE79A63C-20CC-427C-B632-E05E19A45895',1,NULL,2,170.10,GETDATE(), GetDATE()),
('AEDF19D8-6FFC-4CA1-883F-5E1837107C04','F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE',1,NULL,2,170.10,GETDATE(), GetDATE()),
('C6EF3B57-1BC0-4A71-938F-2544C5C9A33A','0B3EEB90-87D3-4093-832F-E122B3DA778E',1,NULL,1,100,GETDATE(), GETDATE()),
('29624DEC-D988-4A83-B95C-481D9F4E03C8','0B3EEB90-87D3-4093-832F-E122B3DA778E',2,NULL,1,100,GETDATE(), GETDATE()),
('4F5738D5-16DF-4C3A-8644-738EC3B4B1F8','0B3EEB90-87D3-4093-832F-E122B3DA778E',3,NULL,1,115,GETDATE(), GETDATE()),
('34EA9A86-2DA4-4C3E-A3EF-314D6C9358C1','0C1A3BC8-17F4-4DC6-85A7-042E509560C2',17,NULL,1,120,GETDATE(), GETDATE()),
('845454DC-4C53-4EC9-BBD3-9F6209328C7E','0C1A3BC8-17F4-4DC6-85A7-042E509560C2',18,NULL,1,150,GETDATE(), GETDATE())

INSERT INTO [MainEcommerceDB].[dbo].[Category]
(Id, Name, parentId, Active) VALUES 
('01', 'Cables & Adapters', NULL, 1),
('02', 'Laptops & Tablets', NULL, 1),
('03', 'Desktop Computers', NULL, 1),
('04', 'Computer Components', NULL, 1),
('05', 'Monitors & Mounts', NULL, 1),
('06', 'Printers, Inks & Toners', NULL, 1),
('07', 'Keyboards & Mice', NULL, 1),
('08', 'Networking & NAS', NULL, 1),
('09', 'Headsets & Headphones', NULL, 1),
('10', 'Pro Audio & Speakers', NULL, 1),
('11', 'Televisions & Home Theatres', NULL, 1),
('12', 'Console Gaming & Educational Toys', NULL, 1),
('13', 'Cameras & Drones', NULL, 1),
('0101', 'Adapters & Gender Changer', '01', 1),
('0102', 'HDMI Cables', '01', 1),
('0103', 'DisplayPort & Mini DisplayPort Cables', '01', 1),
('0104', 'Network Cables', '01', 1),
('0105', 'USB, USB-C & Lightnging Cables', '01', 1),
('0106', 'PC / Computer Cables', '01', 1),
('0107', 'Audio Cables', '01', 1),
('0108', 'Pro Audio Cables', '01', 1),
('0109', 'Video Cables', '01', 1),
('0110', 'Cable Management', '01', 1),
('0111', 'Couplers and Mount Boxes', '01', 1),
('0112', 'Patch Panels & Distribution', '01', 1),
('0113', 'Wall Plates & Keystones', '01', 1),
('0114', 'Batteries', '01', 1),
('0201', 'Business Laptops', '02', 1),
('0202', 'Consumer Laptops', '02', 1),
('0203', 'Gaming Laptops', '02', 1),
('0204', 'Chromebooks', '02', 1),
('0205', 'Tablets', '02', 1),
('0206', 'Add-Ons & Attachments', '02', 1),
('0207', 'Webcams', '02', 1),
('0208', 'Softwares', '02', 1),
('0209', 'Laptop Accessories', '02', 1),
('0210', 'Tablet Accessories', '02', 1),
('0211', 'Bags & Cases', '02', 1),
('0212', 'Cleaning Supplies', '02', 1),
('0213', 'Power Protections', '02', 1),
('0301', 'All-In-One Desktop PC', '02', 1),
('0302', 'Business Desktop PC', '02', 1),
('0303', 'Consumer Desktop PC', '02', 1),
('0304', 'Gaming Desktop PC', '02', 1),
('0305', 'Pre-Built Desktop', '02', 1),
('0306', 'Servers', '02', 1),
('0601', 'Printers', '06', 1),
('0602', 'Inks & Toners', '06', 1),
('0603', 'Scanners', '06', 1),
('0701', 'Keyboards', '07', 1),
('0702', 'Mice', '07', 1),
('0703', 'Keyboard and Mouse Combos', '07', 1),
('0704', 'Mouse Pads/Wrist Rest', '07', 1),
('0705', 'Drawing Tablet', '07', 1),
('0706', 'Presenters', '07', 1),
('070101', 'Keycap, Mouse Bungee/Cable Management and More', '0701', 1),
('070202', 'Refurbished Keyboards and Mice', '0702', 1)

INSERT INTO [MainEcommerceDB].[dbo].[Product] VALUES
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, '0104', 'Basic',			1,	100,		'True',		0.10, 1, 1, 1,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, '0104', 'Normal',			1,	115,		'True',		null, 1, 1, 0,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, '0104', 'Full',			1,	130,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, '0104', 'Basic',			1,	120,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, '0103', 'Normal',			1,	150,		'True',		0.15, 1, 1, 1,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, '0103', 'Full',			1,	170,		'False',	null, 0, 0, 0,	NULL,NULL),
('Lord of the Ring - fellowship',	'Lord of the Ring - fellowship Book',	'LOTR soft copy',									2, '0209', 'Soft Copy',		2,	30,			'False',	null, 0, 0, 0,	NULL,NULL),
('To Kill A Mocking Bird', 			'To Kill A Mocking Bird book',			'TKAMB hard copy',									2, '0210', 'Hard Copy',		4,	40.99,		'True',		0.30, 1, 1, 1,	NULL,NULL),
('Coke - Pack#1',					'6 Pack of Coca Cola',					'Pack of Coca Cola',								3, '0211', 'Warehouse Item',	1,	7.50,		'True',		null, 1, 1, 0,	NULL,NULL),
('Ginger Ale',						'6 Pack of Ginger Ale',					'Pack of Ginger Ale',								3, '070101', 'Warehouse Item',	1,	6.50,		'True',		null, 1, 1, 0,	NULL,NULL),
('Necklace',						'Cross Necklace',						'Sterling Silver Thin 0.6mm Box Chain Necklace',	1, '070101', 'Warehouse Item',	3,	19,			'False',	null, 0, 0, 0,	NULL,NULL),
('Hot Wheels Car',					'Fast and Furios Paul Walker Car',		'Hot wheels R/C 1:64 Mini Nissan Skyline',			1, '070202', 'Warehouse Item',	5,	13,			'True',		null, 1, 1, 0,	NULL,NULL)

INSERT INTO [dbo].Product VALUES
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Basic',			1,100,			'True',		0.10, 1, 1, 1,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Normal',			1,	115,		'True',		null, 1, 1, 0,	NULL,NULL),
('Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Full',			1,	130,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Basic',			1,	120,		'True',		null, 1, 1, 0,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Normal',			1,	150,		'True',		0.15, 1, 1, 1,	NULL,NULL),
('Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Full',			1,	170,		'False',	null, 0, 0, 0,	NULL,NULL),
('Lord of the Ring - fellowship',	'Lord of the Ring - fellowship Book',	'LOTR soft copy',									2, null, 'Soft Copy',		2,	30,			'False',	null, 0, 0, 0,	NULL,NULL),
('To Kill A Mocking Bird', 			'To Kill A Mocking Bird book',			'TKAMB hard copy',									2, null, 'Hard Copy',		4,	40.99,		'True',		0.30, 1, 1, 1,	NULL,NULL),
('Coke - Pack#1',					'6 Pack of Coca Cola',					'Pack of Coca Cola',								3, null, 'Warehouse Item',	1,	7.50,		'True',		null, 1, 1, 0,	NULL,NULL),
('Ginger Ale',						'6 Pack of Ginger Ale',					'Pack of Ginger Ale',								3, null, 'Warehouse Item',	1,	6.50,		'True',		null, 1, 1, 0,	NULL,NULL),
('Necklace',						'Cross Necklace',						'Sterling Silver Thin 0.6mm Box Chain Necklace',	4, null, 'Warehouse Item',	3,	19,			'False',	null, 0, 0, 0,	NULL,NULL),
('Hot Wheels Car',					'Fast and Furios Paul Walker Car',		'Hot wheels R/C 1:64 Mini Nissan Skyline',			5, null, 'Warehouse Item',	5,	13,			'True',		null, 1, 1, 0,	NULL,NULL)

INSERT INTO [dbo].[Address] VALUES
('Habib Shakibanejad',		'222-123-1234', '534 Main St.',				'','Kitchener',		'Ontario',	'Canada',NULL),
('Julio Rivas',				'456-123-1253', '534 Main St.',				'','Kitchener',		'Ontario',	'Canada',NULL),
('Kevin Park',				'234-754-4234', '4 Old Mill Rd.',			'','Waterloo',		'Ontario',	'Canada',NULL),
('Evan',					'867-456-3472', '6412 Westrood Rd.',		'','Guelph',		'Ontario',	'Canada',NULL),
('Michael Jackson',			'876-786-7375', '2355 Cresthaven St.',		'','Toronto',		'Ontario',	'Canada',NULL),
('Roosie McDonald',			'769-456-4565', '87 Orchard Mill Rd.',		'','Ottawa',		'Ontario',	'Canada',NULL),
('Client Eastwood',			'656-456-4554', '48 Booth St.',				'','Kitchener',		'Ontario',	'Canada',NULL),
('hyunbin park Vendor01',	'519-721-5349',	'258 haha my name',			'','Waterloo',		'Ontario',	'Canada',NULL),
('Habib Vendor store',		'656-456-4554', '48 Booth St.',				'','Kitchener',		'Ontario',	'Canada',NULL)

/*
INSERT INTO [dbo].[Customer] VALUES
('habib0303',		1,		1,	'Habib Shakibanejad',	'Customer Description'),
('julio1927',		2,		2,	'Julio Rivas',			'Customer Description'),
('kevin7303',		3,		3,	'Kevin Park',			'Customer Description'),
('4',				4,		4,	'Evan',					'Customer Description'),
('5',				5,		5,	'Michael Jackson',		'Customer Description'),
('Evan1234',		6,		6,	'QWERTTY',				'Customer Description'),
('CustomerID01',	7,		6,	'AZZZZZZa',				'Customer Description'),
('CustomerID02',	7,		6,	'AZZZZZZab',			''),
('CustomerID03',	7,		6,	'AZZZZZZac',			''),
('CustomerID04',	7,		6,	'AZZZZZZad',			''),
('CustomerID05',	7,		6,	'AZZZZZZae',			'')
*/

INSERT INTO [dbo].[Image] VALUES
(1,'wifi installation', 'https://hpecommerce.blob.core.windows.net/kp-container/client1-product1-image1.jpg'),
(1,'wifi installation2', 'https://hpecommerce.blob.core.windows.net/kp-container/client1-product1-image2.jpg'),
(1,'wifi installation2-1', 'https://hpecommerce.blob.core.windows.net/kp-container/client1-product1-image3.jpg'),
(11,'Nike Shoes#01', 'https://hpecommerce.blob.core.windows.net/kp-container/client10-product11-Image5.jpg'),
(11,'Nike Shoes#02', 'https://hpecommerce.blob.core.windows.net/kp-container/client10-product11-Image6.jpg'),
(2,'Kevin''s Pokemon#1', 'https://hpecommerce.blob.core.windows.net/kp-container/client2-Image7.jpg'),
(1,'wifi installation3-1K','www.google.com/12354666')


INSERT INTO [dbo].[Order] VALUES
('320B0B38-8344-454E-AE6E-CF3511C817A2','habib0303',1,'981D835A-A255-4CF5-B868-FCB054326A97','R','COMMENT',CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-22 12:35:00.0000' AS datetimeoffset(7))),
('83065B6C-0DF1-4B29-9993-0F91034C71ED','habib0303',2,'F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A','S','COMMENT',CAST('2021-04-22 14:35:29.1234' AS datetimeoffset(7)),CAST('2007-05-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('967EC618-CE1E-47C8-A8DE-CAB31A5F40D7','kevin7303',1,'CE79A63C-20CC-427C-B632-E05E19A45895','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-15 12:35:29.1234' AS datetimeoffset(7))),
('13E57F7B-E238-4511-B637-6EBBDCA2580F','julio1927',1,'F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('38B7589E-3AAC-45C0-8D45-D1C60B8E41F2','julio1927',2,'0C1A3BC8-17F4-4DC6-85A7-042E509560C2','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('09FD4C8B-F224-43CD-AFAE-7DFCCA93D8BD','Evan1234',3,'0B3EEB90-87D3-4093-832F-E122B3DA778E','R','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7)))

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
