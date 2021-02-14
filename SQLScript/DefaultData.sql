USE [MainEcommerceDB]
GO

INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Wifi Installing',				'Installing wifi at location',				'Optix',			'Basic',	1,	100,	NULL,	'True'	,1,		NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Wifi Installing',				'Installing wifi at location',				'Optix',			'Normal',	1,	115,	NULL,	'True'	,1,		NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Wifi Installing',				'Installing wifi at location',				'Optix',			'Full',		1,	130,	NULL,	'True'	,1,		NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Fiber optic cable',				'Installing Fiber Optic Cable',				'Optix',			'Basic',	1,	120,	NULL,	'True'	,2,		NULL,	'Optix Network solutions service')
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Fiber optic cable',				'Installing Fiber Optic Cable',				'Optix',			'Normal',	1,	150,	NULL,	'True'	,2,		NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Fiber optic cable',				'Installing Fiber Optic Cable',				'Optix',			'Full',		1,	170,	NULL,	'False' ,2,		NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Lord of the Ring - fellowship', 'LOTR e-book',								'Kevin Bookstore',	'E-Book',	1,	10,		NULL,	'True',	null,	NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Lord of the Ring - fellowship', 'LOTR hard copy',							'Kevin Bookstore',	'InStore',	1,	10,		NULL,	'True',	null,	NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Coke - Pack#1',					'Pack of Coca Cola',						'Julio Grocery',	'InStore',	6,	12,		NULL,	'True',	null,	NULL,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Description],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[Discount],[UnitsInStock],[CategoryId],[ImageAddress],[Note])VALUES(NEWID(),'Coke - Pack#1',				    'Pack of Coca Cola',						'Julio Grocery',	'App',		6,	13,		NULL,	'True',	null,	NULL,	NULL)

select * from Product




