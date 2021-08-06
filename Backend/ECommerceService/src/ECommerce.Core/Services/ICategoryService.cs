﻿using ECommerce.Core.Models.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.BusinessServices
{
    public interface ICategoryService
    {
        IList<Category> GetCategoriesById(string categoryId);
        IList<Category> GetCategoriesByName(string categoryName);
        IList<Category> GetCategoriesByParentId(string categoryId);
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<bool> DeleteCategory(string categoryId);
    }
}
