using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AzureStorage
{
    public class AzureBlobStorageService : IAzureBlobStorageService
    {
        // https://www.wintellect.com/azure-bits-2-saving-the-image-to-azure-blob-storage/
        //https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-container-create?tabs=dotnet
        private readonly string _imageRootPath;
        private static readonly string _container = "kp-container";
        private readonly string _blobStorageConn;
        private BlobServiceClient blobServiceClient = null;
        public AzureBlobStorageService(string connectionString = null, string imageRootPath = null)
        {
            _imageRootPath = imageRootPath ?? "C:\\Users\\Hyunbin\\Desktop\\";
            _blobStorageConn = connectionString ?? Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
            if (_blobStorageConn != null)
            {
                blobServiceClient = new BlobServiceClient(_blobStorageConn);
            }
        }
        public Task AddImageToBlobStorageAsync(BlobDTO image)
        {
            throw new NotImplementedException();
        }
        public async Task BlobDownloadInfoAsync(BlobClient blobClient, string filePath)
        {
            // Append the string "DOWNLOADED" before the .txt extension 
            // so you can compare the files in the data directory
            string downloadFilePath = filePath.Replace(".txt", "DOWNLOADED.txt");
            Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);
            // Download the blob's contents and save it to a file
            BlobDownloadInfo download = await blobClient.DownloadAsync();
            using (FileStream downloadFileStream = File.OpenWrite(downloadFilePath))
            {
                await download.Content.CopyToAsync(downloadFileStream);
                downloadFileStream.Close();
            }
        }
        //public static List<V> ListAllBlobs<T, V>(Expression<Func<T, V>> expression, string containerName, string prefix)
        //{
        //    CloudStorageAccount storageAccount = CloudStorageAccount.Parse("YourConnectionString;");
           
        //    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_container);
        //    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();
        //    CloudBlobContainer container = cloudBlobClient.GetContainerReference(containerName);
        //    container.CreateIfNotExists();
        //    var list = container.ListBlobs(prefix: prefix, useFlatBlobListing: true);
        //    List<V> data = list.OfType<T>().Select(expression.Compile()).ToList();
        //    return data;
        //}
       


        public void DeleteContainer(string containerName)
        {
            // Try to delete a container  and avoid any potential race conditions that might arise by checking if the container is already deleted or is in the process of being deleted.
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(containerName);
            try
            {
                container.Delete();
            }
            catch (RequestFailedException ex)
                when (ex.ErrorCode == BlobErrorCode.ContainerBeingDeleted ||
                      ex.ErrorCode == BlobErrorCode.ContainerNotFound)
            {
                // Ignore any errors if the container being deleted or if it has already been deleted
            }
        }
        public Task<BlobItem> GetBlobItemByFileName(string fileName)
        {
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_container);
            var blobs = containerClient.GetBlobs();
            foreach (BlobItem b in blobs)
            {
                if (b.Name == fileName)
                {
                    return Task.FromResult(b);
                }
            }
            return null;
        }
        public async Task<Entity> GetEntityBlobAsync<Entity>(BlobClient blobJson) where Entity : class, new()
        {
            try
            {
                using (MemoryStream s = new MemoryStream())
                {
                    await blobJson.DownloadToAsync(s);
                    using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
                    {
                        using (JsonReader reader = new JsonTextReader(sr))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            return serializer.Deserialize<Entity>(reader);
                        }
                    }
                }
            }
            catch (RequestFailedException ex)
                when (ex.ErrorCode == BlobErrorCode.BlobNotFound)
            {
                return null;
            }
        }
        public IList<string> GetBlobItemsFromContainer(string containerName)
        {
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            List<string> fileNames = new List<string>();
            foreach (BlobItem blobItem in containerClient.GetBlobs())
                fileNames.Add(blobItem.Name);
            return fileNames;
        }
        public string GetFileUrl(string iamgeName)
        {
            throw new NotImplementedException();
        }
        public Task SaveFileAsync(Stream fileBinaryStream, string fileName, string mimeType = null)
        {
            throw new NotImplementedException();
        }
        public async void UploadFile(string fileName, string containerName = "kp-container")
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_blobStorageConn);
            string _containerName = containerName;
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
            string localFilePath = Path.Combine(_imageRootPath, fileName);

            BlobClient blobClient = containerClient.GetBlobClient("KevinPark_Resume.pdf");
            Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

            using FileStream uploadFileStream = File.OpenRead(localFilePath);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();
        }


    }
}
