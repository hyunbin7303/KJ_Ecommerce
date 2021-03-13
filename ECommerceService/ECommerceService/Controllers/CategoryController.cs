using ECommerce.Domain.Models;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
        private ICategoryRepository _categoryRepository = null;
        private IProductRepository _productRepository = null;
        public CategoryController(ICategoryRepository categoryRepo, IProductRepository productRepo)
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

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> CreateAsync(Category category)
        {
            try
            {
                if (category.Name.Contains("XYZ Widget"))
                {
                    return BadRequest();
                }
                _categoryRepository.Insert(category);
                return CreatedAtAction(nameof(Category), new { id = category.Id }, category);

            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }


    }
}
