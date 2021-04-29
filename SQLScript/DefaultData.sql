USE [MainEcommerceDB]
GO
INSERT INTO [dbo].[Category]([Name], [ProductId])VALUES('Example Category', null)
GO
INSERT INTO [dbo].Product VALUES
(1,'Wifi Installation',				'Wifi Installation',	'Installing wifi at location',1, null, 'Basic',1,100,'True',0.10, 1, 1, 1,NULL,NULL),
(2,'Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Normal',			1,	115,		'True',		null, 1, 1, 0,	NULL,NULL),
(3,'Wifi Installation',				'Wifi Installation',					'Installing wifi at location',						1, null, 'Full',			1,	130,		'True',		null, 1, 1, 0,	NULL,NULL),
(4,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Basic',			1,	120,		'True',		null, 1, 1, 0,	NULL,NULL),
(5,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Normal',			1,	150,		'True',		0.15, 1, 1, 1,	NULL,NULL),
(6,'Fiber optic cable Installation',	'Cable Installation',					'Installing Fiber Optic Cable',						1, null, 'Full',			1,	170,		'False',	null, 0, 0, 0,	NULL,NULL),
(7,'Lord of the Ring - fellowship',	'Lord of the Ring - fellowship Book',	'LOTR soft copy',									2, null, 'Soft Copy',		2,	30,			'False',	null, 0, 0, 0,	NULL,NULL),
(8,'To Kill A Mocking Bird', 			'To Kill A Mocking Bird book',			'TKAMB hard copy',									2, null, 'Hard Copy',		4,	40.99,		'True',		0.30, 1, 1, 1,	NULL,NULL),
(9,'Coke - Pack#1',					'6 Pack of Coca Cola',					'Pack of Coca Cola',								3, null, 'Warehouse Item',	1,	7.50,		'True',		null, 1, 1, 0,	NULL,NULL),
(10,'Ginger Ale',						'6 Pack of Ginger Ale',					'Pack of Ginger Ale',								3, null, 'Warehouse Item',	1,	6.50,		'True',		null, 1, 1, 0,	NULL,NULL),																																				    
(11,'Necklace',						'Cross Necklace',						'Sterling Silver Thin 0.6mm Box Chain Necklace',	4, null, 'Warehouse Item',	3,	19,			'False',	null, 0, 0, 0,	NULL,NULL),
(12,'Hot Wheels Car',					'Fast and Furios Paul Walker Car',		'Hot wheels R/C 1:64 Mini Nissan Skyline',			5, null, 'Warehouse Item',	5,	13,			'True',		null, 1, 1, 0,	NULL,NULL)		
GO
INSERT INTO [dbo].[Address] VALUES
(1,'Habib Shakibanejad',	'222-123-1234', '534 Main St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
(2,'Julio Rivas',			'456-123-1253', '534 Main St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
(3,'Kevin Park',			'234-754-4234', '4 Old Mill Rd.',		'','Waterloo',		'Ontario',	'Canada',NULL),
(4,'Evan',					'867-456-3472', '6412 Westrood Rd.',	'','Guelph',		'Ontario',	'Canada',NULL),
(5,'Michael Jackson',		'876-786-7375', '2355 Cresthaven St.',	'','Toronto',		'Ontario',	'Canada',NULL),
(6,'Roosie McDonald',		'769-456-4565', '87 Orchard Mill Rd.',	'','Ottawa',		'Ontario',	'Canada',NULL),
(7,'Client Eastwood',		'656-456-4554', '48 Booth St.',			'','Kitchener',		'Ontario',	'Canada',NULL),
(8,'hyunbin park Vendor01', '519-721-5349',	'258 haha my name',		'','Waterloo',		'Ontario',	'Canada',NULL),
(9,'Habib Vendor store',	'656-456-4554', '48 Booth St.',			'','Kitchener',		'Ontario',	'Canada',NULL)
GO
INSERT INTO [dbo].[Customer] VALUES 
('habib0303',1,1,'Habib Shakibanejad',null),
('julio1927',2,2,'Julio Rivas',null),
('kevin7303',3,3,'Kevin Park',null),
('4',4,4,'Evan',null),
('5',5,5,'Michael Jackson',null),
('Evan1234',6,6,'Chris Tucker',null)
GO
INSERT INTO [dbo].Cart VALUES
('981D835A-A255-4CF5-B868-FCB054326A97','habib0303',GETDATE()-1),
('F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A','habib0303',CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('CE79A63C-20CC-427C-B632-E05E19A45895','kevin7303',GETDATE()-3),
('F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE','julio1927',GETDATE()-4),
('0C1A3BC8-17F4-4DC6-85A7-042E509560C2','julio1927',GETDATE()-5),
('0B3EEB90-87D3-4093-832F-E122B3DA778E','Evan1234',GETDATE()-6),
('C0E48D99-4C13-44F8-B8AE-1DBE0ABBE4F5','',GETDATE()-7),
('72F75054-669A-44A6-88BC-144E4A3F72B3','',GETDATE()-8),
('B79D641B-A39E-4B43-8FA2-81BB6D1D733E','',GETDATE()-9)

INSERT INTO [dbo].CartItem VALUES
('4D30F537-CA8C-43D9-ADE3-AE8421A4E920','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('B1AAFACC-0A5C-4090-B0E5-36446F861627','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('F5588E00-62BA-4A50-9EC0-36E55A6EF76A','981D835A-A255-4CF5-B868-FCB054326A97',1,2,170.10,GETDATE()),
('AE0A0E8D-7548-49F3-81BB-8E2C1F5885EF','CE79A63C-20CC-427C-B632-E05E19A45895',1,2,170.10,GETDATE()),
('AEDF19D8-6FFC-4CA1-883F-5E1837107C04','F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE',1,2,170.10,GETDATE())

INSERT INTO [dbo].[Image] VALUES
(1,1,'wifi installation','www.google.com'),
(2,1,'wifi installation2','www.google.com/12354'),
(3,1,'wifi installation2-1','www.google.com/12357774'),
(4,1,'wifi installation3-1K','www.google.com/12354666')

INSERT INTO [dbo].[Order] VALUES
('320B0B38-8344-454E-AE6E-CF3511C817A2','habib0303',1,'981D835A-A255-4CF5-B868-FCB054326A97','R','COMMENT',CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-21 08:35:00.0000' AS datetimeoffset(7)),CAST('2021-04-22 12:35:00.0000' AS datetimeoffset(7))),
('83065B6C-0DF1-4B29-9993-0F91034C71ED','habib0303',2,'F42508CB-BCEB-4E2F-B8EC-E9F8C71A805A','S','COMMENT',CAST('2021-04-22 14:35:29.1234' AS datetimeoffset(7)),CAST('2007-05-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-23 13:55:29.1234' AS datetimeoffset(7))),
('967EC618-CE1E-47C8-A8DE-CAB31A5F40D7','kevin7303',1,'CE79A63C-20CC-427C-B632-E05E19A45895','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-15 12:35:29.1234' AS datetimeoffset(7))),
('13E57F7B-E238-4511-B637-6EBBDCA2580F','julio1927',1,'F6EBA2CB-2FE0-4EE8-95B4-EF268B7503FE','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('38B7589E-3AAC-45C0-8D45-D1C60B8E41F2','julio1927',2,'0C1A3BC8-17F4-4DC6-85A7-042E509560C2','N','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7))),
('09FD4C8B-F224-43CD-AFAE-7DFCCA93D8BD','Evan1234',3,'0B3EEB90-87D3-4093-832F-E122B3DA778E','R','HI',CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-08 12:35:29.1234' AS datetimeoffset(7)),CAST('2021-04-20 12:35:29.1234' AS datetimeoffset(7)))

INSERT INTO [dbo].OrderItem VALUES
('FA403181-A1FE-4AB3-8172-43CBDE66E703','320B0B38-8344-454E-AE6E-CF3511C817A2'),
('E7937FF9-945B-4753-9C4B-B629FA067677','320B0B38-8344-454E-AE6E-CF3511C817A2'),
('09A74D43-EE03-48B1-8B10-EFCADCEA45D3','320B0B38-8344-454E-AE6E-CF3511C817A2'),
('FD8A7F26-36B5-40A3-BD81-43460EED7283','83065B6C-0DF1-4B29-9993-0F91034C71ED')


INSERT INTO [dbo].[Vendor] VALUES(1,'Vendor01',7,'123-4567-1234','hyunbin7303@hb.com','hyunbin7303@gmail.com','Hyunbin Clinet vendor')
INSERT INTO [dbo].[Vendor] VALUES(2,'kevin''s store',8,'123-4567-1234','asdf@hb.com','h12321321@gmail.com','kevins vendor store')
INSERT INTO [dbo].[Vendor] VALUES(3,'Julio Restaurant',9,'555-6666-1234','bbbbbaaa@hb.com','hasdfdsafsda303@gmail.com','Haaaa')

