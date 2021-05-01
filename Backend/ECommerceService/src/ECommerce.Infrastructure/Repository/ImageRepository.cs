using ECommerce.AzureStorage;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class ImageRepository : IImageRepository
    {
        public void DeleteImage(int imageId)
        {
            throw new NotImplementedException();
        }

        // Not working right now. Need to check. 
        public IEnumerable<Image> GetImageFileUrl(string productId, string productName, string vendorId)
        {
            string _fileName = vendorId + "|" + productId + "|" + productName + ".jpg";
            AzureBlobStorageService service = new AzureBlobStorageService();
            var check = service.GetFileUrl(_fileName);
            return null;
        }
        public void InsertImage(IFormFile file)
        {
            AzureBlobStorageService service = new AzureBlobStorageService();
            // TODO : CHeck if container exists.
            // get file information and call insert.
            service.AddImageToBlobStorageAsync(null); // this one or
            throw new NotImplementedException();
        }
        public Task<bool> SaveImage(string pictureName, string pictureBase64, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
