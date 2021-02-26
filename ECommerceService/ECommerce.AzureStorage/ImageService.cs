using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AzureStorage
{
    public class ImageService : IImageService
    {
        // https://www.wintellect.com/azure-bits-2-saving-the-image-to-azure-blob-storage/
        private readonly string _imageRootPath;
        private readonly string _container;
        private readonly string _blobStorageConn;
        public ImageService(string containerName, string connectionString = null, string imageRootPath = null)
        {
            _imageRootPath = imageRootPath ?? "C:\\Users\\Hyunbin\\Desktop\\";
            _blobStorageConn = connectionString ?? Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
            _container = containerName;
        }
        public Task AddImageToBlobStorageAsync(BlobDTO image)
        {
            throw new NotImplementedException();
        }
        public void DeleteContainer(string containerName)
        {
            // Try to delete a container  and avoid any potential race conditions that might arise by checking if the container is already deleted or is in the process of being deleted.
            BlobContainerClient container = AzureBlobManager.GetBlobContainerClient(containerName);
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

        public Task<BlobDTO> GetBlobAsync(GetBlobRequestDTO input)
        {
            // var blob = await _fileContainer.getAllBytesAsync(input.Name);
            BlobServiceClient blobServiceClient = new BlobServiceClient(_blobStorageConn);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_container);
            return null;
        }
        public void GetBlobItemsFromContainer(string containerName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_blobStorageConn);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            foreach (BlobItem blobItem in containerClient.GetBlobs())
            {
                Console.WriteLine("\t" + blobItem.Name);
            }
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
    }
}
