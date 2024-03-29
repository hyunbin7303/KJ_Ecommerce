﻿using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ECommerceService.Interfaces
{
    public interface IProductService
    {
        Task<Product> SearchProduct(); // change this code later(To get more paras)
        IList<ProductDisplayDTO> GetProductDisplays();
        Task<IList<ProductDisplayDTO>> GetProductsByVendorId(int vendorId);
        IList<Product> GetProductsByDisplayNameContains(string name);
        IList<Product> GetProductsByCategoryId(int categoryId);
        Task<IList<Product>> GetProductsOnSale();
        Task CreateProduct(ProductCreateDTO product); 
        Task UpdateProduct(ProductUpdateDTO product);
        Task<bool> DeleteProduct(int productId);
    }
}
