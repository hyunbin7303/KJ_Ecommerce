USE [MainEcommerceDB]
GO

INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Wifi Installing',				'Optix',			'Basic',	1,100,	'True'	,1,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Wifi Installing',				'Optix',			'Normal',	1,115,	'True'	,1,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Wifi Installing',				'Optix',			'Full',		1,130,	'True'	,1,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Fiber optic cable',			'Optix',			'Basic',	1,120,	'True'	,2,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Fiber optic cable',			'Optix',			'Normal',	1,150,	'True'	,2,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Fiber optic cable',			'Optix',			'Full',		1,170,	'False' ,2,		NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Lord of the Ring - fellowship','Kevin Bookstore',	'E-Book',	1,10,	'True',	null,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Lord of the Ring - fellowship','Kevin Bookstore',	'InStore',	1,10,	'True',	null,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Coke - Pack#1',				'Julio Grocery',	'InStore',	6,12,	'True',	null,	NULL)
INSERT INTO [dbo].[Product]([Id],[Name],[Customer],[ProductFormat],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[CategoryId],[ImageAddress])VALUES(NEWID(),'Coke - Pack#1',				'Julio Grocery',	'App',		6,13,	'True',	null,	NULL)

select * from Product
WHERE [Customer] = 'Optix'



