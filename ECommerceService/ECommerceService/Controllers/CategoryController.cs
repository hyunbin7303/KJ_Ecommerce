using ECommerce.Domain.Models;
using ECommerce.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //API endpoint: /api/categories
        //private readonly CatalogSettings _catalogSettings;
        //private readonly IAclService _aclService;
        //private readonly ICatalogModelFactory _catalogModelFactory;
        //private readonly ICategoryService _categoryService;
        //private readonly ICustomerActivityService _customerActivityService;
        //private readonly IGenericAttributeService _genericAttributeService;
        //private readonly ILocalizationService _localizationService;
        //private readonly IManufacturerService _manufacturerService;
        //private readonly IPermissionService _permissionService;
        //private readonly IProductModelFactory _productModelFactory;
        //private readonly IProductService _productService;
        //private readonly IProductTagService _productTagService;
        //private readonly IStoreContext _storeContext;
        //private readonly IStoreMappingService _storeMappingService;
        //private readonly IVendorService _vendorService;
        //private readonly IWebHelper _webHelper;
        //private readonly IWorkContext _workContext;
        //private readonly MediaSettings _mediaSettings;
        //private readonly VendorSettings _vendorSettings;
        private IGenericRepository<Category> _categoryRepository = null;
        private IGenericRepository<Product> _productRepository = null;
        public CategoryController(IGenericRepository<Category> categoryRepo, IGenericRepository<Product> productRepo)
        {
            this._categoryRepository = categoryRepo;
            this._productRepository = productRepo;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var allCategories = _categoryRepository.GetAll();
            return allCategories;
        }
        //[HttpGet("Details")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Category))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public IActionResult CategoryDetails(string categoryId)
        //{
        //    var product = _productRepository.GetByCate(categoryId);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}



    }
}
