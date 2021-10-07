﻿using ECommerce.Core.Interfaces;
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

        [HttpGet("GetVendorsByUser")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vendor))]
        public IEnumerable<Vendor> GetVendorsByUser(string user)
        {
            var vendors = _vendorService.GetVendorsByUser(user)?.Result;
            return vendors;
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Vendor> CreateAsync([FromBody]Vendor vendor)
        {
            try
            {
                _vendorRepository.InsertAsync(vendor);
                return CreatedAtAction(nameof(CreateAsync), new { id = vendor }, vendor);
            }
            catch (Exception e)
            {
                return ValidationProblem(e.Message);
            }
        }
    }
}
