USE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 2021-03-29 10:04:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ProductId] [nvarchar](50) NULL
) ON [PRIMARY]
GO


