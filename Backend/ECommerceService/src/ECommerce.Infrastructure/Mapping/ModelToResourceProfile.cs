using AutoMapper;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Mapping
{
    public class ModelToResourceProfile : Profile
    { 
        public ModelToResourceProfile()
        {
            CreateMap<Product, ProductDetailsDTO>();
            //    .ForMember(src => src.UnitOfMeasurement,
            //               opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
