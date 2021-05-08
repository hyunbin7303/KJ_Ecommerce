
using ECommerce.AzureStorage;
using NUnit.Framework;

namespace ECommerceService.Test
{
    class AzureTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GetBlobItemsFromContainer_NullCheck()
        {
            AzureBlobStorageService imageService = new AzureBlobStorageService();
            var check = imageService.GetBlobItemsFromContainer("kp-container");
            Assert.IsNotNull(check);
        }
        [Test]
        public void GetGetBlobAsync_FindExistingFileInBlobContainer()
        {
            AzureBlobStorageService imageService = new AzureBlobStorageService();
            var check = imageService.GetBlobItemByFileName("client1-product2-Image1.jpg");
            Assert.AreEqual(check.Result.Name, "client1-product2-Image1.jpg");
        }
        [Test]
        public void CreateContainerAsync_CreateValidContainer()
        {
        }
        [Test]
        public void DeleteContainer_ReturnTrueIfSuccess()
        {
            AzureBlobStorageService service = new AzureBlobStorageService("kp-container");

        }
    }
}
