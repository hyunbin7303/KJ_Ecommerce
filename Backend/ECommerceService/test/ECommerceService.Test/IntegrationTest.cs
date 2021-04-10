using ECommerce.AzureStorage;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ECommerceService.Test
{
    public class IntegrationTest
    {
        protected readonly HttpClient _client;
        private readonly WebApplicationFactory<Startup> _factory;
        public IntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }
        [Test]
        [TestCase("/")]
        [TestCase("/Index")]
        [TestCase("/About")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentTypeAsync(string url)
        {
            // Arrange
            var client = _factory.CreateClient();
            // Act
            var response = await client.GetAsync(url);
            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.AreEqual("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }


        protected async Task AuthenticateAsync()
        {
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", await GetJwtAsync());
        }
        //private async Task<string> GetJwtAsync()
        //{

        //}


    }
}