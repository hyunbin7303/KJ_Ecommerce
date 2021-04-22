using AutoMapper;
using ECommerce.Domain.Models;
using ECommerce.Infrastructure.Models;
using ECommerce.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Mapping
{
    // The best implementation of AutoMapper for class libraries - https://stackoverflow.com/questions/26458731/how-to-configure-auto-mapper-in-class-library-project
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
           {
               cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
               cfg.AddProfile<ModelToResourceProfile>();
           });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;

        public class ModelToResourceProfile : Profile
        {
            public ModelToResourceProfile()
            {
                // Create maps 
                CreateMap<Product, ProductDetailsDTO>();


            }
        }
    }
}
