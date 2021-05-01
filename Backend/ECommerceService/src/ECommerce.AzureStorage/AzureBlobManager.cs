using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.AzureStorage
{
    public class AzureBlobManager
    {
        static public string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
        static public string filePath = "C:\\Users\\Hyunbin\\Desktop\\";

        static public void GetBlobItemsFromContainer(string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            foreach (BlobItem blobItem in containerClient.GetBlobs())
            {
                Console.WriteLine("\t" + blobItem.Name);
            }
        }
        public static BlobContainerClient GetBlobContainerClient(string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient("StorageConnectionString");
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(containerName);
            return container;
        }
    }
}
