using System;
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace ECommerce.AzureStorage
{

    class Program
    {
        static public string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            //Create a unique name for the container
            string containerName = "ECommerceblobsTest";
            // Create the container and return a container client object
            BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
        }
    }
}
