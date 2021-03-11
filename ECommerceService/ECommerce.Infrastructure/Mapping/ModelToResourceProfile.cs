using AutoMapper;
using ECommerce.Domain.Models;
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
