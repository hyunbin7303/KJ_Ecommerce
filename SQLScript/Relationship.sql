USE [MainEcommerceDB]
GO


ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customers_CustomerId]
GO


---- alter table [Payment]
--FOREIGN KEY REFERENCES Invoice (Id) NOT NULL
-- FOREIGN KEY REFERENCES PaymentMethod(Id) NOT NULL
