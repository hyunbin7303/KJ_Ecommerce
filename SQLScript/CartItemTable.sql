USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[CartItem]    Script Date: 2021-04-03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CartItem](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CartID] [int],
	CreatedDate DATETIME,
	CONSTRAINT CartItem_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_CartItem PRIMARY KEY(Id),
);