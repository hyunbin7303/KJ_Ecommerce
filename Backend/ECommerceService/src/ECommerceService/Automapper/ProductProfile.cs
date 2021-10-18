using AutoMapper;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Automapper
{
	public class ProductProfile : Profile
	{
		public ProductProfile()
		{
			CreateMap<Product, ProductCreateDTO>().ReverseMap();
			CreateMap<Product, ProductDisplayDTO>().ReverseMap();
			CreateMap<Product, ProductUpdateDTO>().ReverseMap();
		}
	}
}
