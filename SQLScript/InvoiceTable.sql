lUSE [MainEcommerceDB]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 2021-03-29 10:00:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[CustomerId] [nvarchar](255) NULL,
    [SubTotal] [decimal] NOT NULL,
	[ShippingTotal] [decimal] NULL, 
    [Total] [decimal](18) NULL,
    [ShippingToId] [nvarchar](255) NOT NULL,
	[BillingToId] [nvarchar](255) NOT NULL
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO

ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customers_CustomerId]
GO

