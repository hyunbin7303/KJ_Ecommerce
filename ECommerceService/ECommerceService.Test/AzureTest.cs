using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ECommerce.AzureStorage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            ImageService imageService = new ImageService();
            var check = imageService.GetBlobItemsFromContainer("kp-container");
            //foreach (BlobItem blobItem in check)
            //    Console.WriteLine("\t" + blobItem.Name);
            Assert.IsNotNull(check);
        }

        [Test]
        public void GetBlobAsync_FindExistingFileInBlobContainer()
        {
            ImageService service = new ImageService();
            var check = service.GetBlobAsync(new GetBlobRequestDTO{ Name = "KevinPark_Resume.pdf"});
            Assert.IsNotNull(check);
        }

        [Test]
        public void CreateContainerAsync_CreateValidContainer()
        {
            var connStr = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
            BlobServiceClient client = new BlobServiceClient(connStr);
            var check = ImageService.CreateContainerAsync(client, "test-01");
            Assert.AreEqual(TaskStatus.RanToCompletion, check.Status);
        }

        [Test]
        public void DeleteContainer_ReturnTrueIfSuccess()
        {
            ImageService service = new ImageService("kp-container");

        }
    }
}
