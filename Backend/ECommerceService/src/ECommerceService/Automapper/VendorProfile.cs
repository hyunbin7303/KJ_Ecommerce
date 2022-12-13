using AutoMapper;
using ECommerce.Core.Models;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using ECommerce.Query.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Automapper
{
	public class VendorProfile : Profile
	{
		public VendorProfile()
		{
			CreateMap<Vendor, VendorCreateDTO>().ReverseMap();
			CreateMap<Vendor, VendorDisplayDTO>().ReverseMap();
		}
	}
}
