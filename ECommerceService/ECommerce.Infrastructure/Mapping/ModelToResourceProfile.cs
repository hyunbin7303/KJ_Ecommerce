using AutoMapper;
using ECommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            //CreateMap<Category, CategoryResource>();

            //CreateMap<Product, ProductResource>()
            //    .ForMember(src => src.UnitOfMeasurement,
            //               opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
