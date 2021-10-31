using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;
using ECommerceService.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Query.Vendor;

namespace ECommerceService.Controllers
{
    public class VendorController : BaseController
    {
        private IVendorRepository _vendorRepository = null;
        private IVendorService _vendorService = null;

        public VendorController(IVendorRepository vendorRepository, IVendorService vendorService)
        {
            _vendorRepository = vendorRepository ?? null;
            _vendorService = vendorService ?? null;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vendor))]
        public IEnumerable<Vendor> Get()
        {
            return _vendorRepository.GetAll();
        }

        [HttpGet("vendors")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vendor))]
        public ActionResult<Vendor> GetVendorsByName(string vendorName)
        {
            return Ok(_vendorService.GetVendorByName(vendorName));
        }


        [HttpGet("domain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vendor))]
        public IEnumerable<VendorDisplayDTO> GetVendorsByDomainUser(string domainUser)
        {
            var vendors = _vendorService.GetVendorsByDomainUser(domainUser);
            return vendors;
        }  

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Vendor> CreateAsync([FromBody]VendorCreateDTO vendor)
        {
            try
            {
                _vendorService.CreateVendor(vendor, "");
                //_vendorRepository.InsertAsync(vendor);
                return CreatedAtAction(nameof(CreateAsync), new { id = vendor }, vendor);
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
