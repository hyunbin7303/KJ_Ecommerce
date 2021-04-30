using AutoMapper;
using ECommerce.Query;
using ECommerce.Core.Models.ProductAggregate;

namespace ECommerce.Infrastructure.Mapping
{
    // The best implementation of AutoMapper for class libraries - https://stackoverflow.com/questions/26458731/how-to-configure-auto-mapper-in-class-library-project
    public static class ObjectMapper
    {
        public static void Initialize()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
           {
               cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
               cfg.AddProfile<ModelToResourceProfile>();
           });
            Mapper = MapperConfiguration.CreateMapper();
        }

        public static IMapper Mapper { get; private set; }

        public static MapperConfiguration MapperConfiguration { get; private set; }

        public class ModelToResourceProfile : Profile
        {
            public ModelToResourceProfile()
            {
                // Create maps 
                CreateMap<Product, ProductDetailsDTO>().ReverseMap(); // reverse map is so that we dont have to create a map the other way around e.g  CreateMap<ProductModel, Product>() it unflattens it
            }
        }
    }
}
