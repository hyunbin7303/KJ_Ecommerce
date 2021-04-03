USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Cart]    Script Date: 2021-04-03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cart](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreatedDate] [DATETIME] NOT NULL,
	CONSTRAINT Cart_CreatedDate CHECK (CreatedDate > '1 April 2021'),
	CONSTRAINT PK_Cart PRIMARY KEY(Id)
);