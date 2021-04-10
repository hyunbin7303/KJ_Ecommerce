using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Test
{
    public class ProductControllerTest : IntegrationTest
    {
        public ProductControllerTest(WebApplicationFactory<Startup> factory) : base(factory)
        {
        }
        public async Task GetAll_WithoutAnyProducts_ReturnsEmptyResponse()
        {

        }
    }
}
