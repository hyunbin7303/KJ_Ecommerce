ALTER TABLE [OrderItem] ADD CONSTRAINT FK_OrderId FOREIGN KEY (OrderId) REFERENCES [Order](id);
ALTER TABLE [OrderItem] ADD CONSTRAINT FK_ProductId FOREIGN KEY (ProductId) REFERENCES [Product](id);
ALTER TABLE [Product]   ADD CONSTRAINT FK_CategoryId FOREIGN KEY (CategoryId) REFERENCES [Category](id);
ALTER TABLE [Product]   ADD CONSTRAINT FK_VendorId FOREIGN KEY   (VendorId) REFERENCES [Vendor](id);
ALTER TABLE [CartItem]   ADD CONSTRAINT FK_CartId FOREIGN KEY   (CartId) REFERENCES [Cart](id);
ALTER TABLE [Payment]   ADD CONSTRAINT FK_PaymentMethodId FOREIGN KEY   (PaymentMethodId) REFERENCES [PaymentMethod](id);
ALTER TABLE [ProductAttribute]   ADD CONSTRAINT FK_ProductAttribute_ProudctId FOREIGN KEY   (ProductId) REFERENCES [Product](id);
ALTER TABLE [ProductAttribute]   ADD CONSTRAINT FK_ProductAttribute_AttributeId FOREIGN KEY (AttributeId) REFERENCES [Attribute](id);
