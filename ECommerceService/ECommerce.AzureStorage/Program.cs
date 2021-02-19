using System;
using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace ECommerce.AzureStorage
{

    class Program
    {
        static public string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
        static public string filePath = "C:\\Users\\Hyunbin\\Desktop\\";
        static public async void UploadFile(string fileName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            string containerName = "kp-container";
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);

            string localFilePath = Path.Combine(filePath, fileName);

            BlobClient blobClient = containerClient.GetBlobClient("KevinPark_Resume.pdf");
            Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

            // Open the file and upload its data
            using FileStream uploadFileStream = File.OpenRead(localFilePath);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();

        }
        static public void GetBlobItemsFromContainer(string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            foreach (BlobItem blobItem in containerClient.GetBlobs())
            {
                Console.WriteLine("\t" + blobItem.Name);
            }
        }

        static public async System.Threading.Tasks.Task Main(string[] args)
        {

        //    GetFilesFromAzureBlob("kp-container");


        }
    }
}
