using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.AzureStorage
{

    public interface IImageService
    {
        Task AddImageToBlobStorageAsync(BlobDTO image);
        void DeleteContainer(string containerName);
        Task<Entity> GetEntityBlobAsync<Entity>(BlobClient blobJson) where Entity : class, new();
    }

}
