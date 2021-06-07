using ECommerce.AzureStorage;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Repository.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        private static readonly string _azure_root = "https://hpecommerce.blob.core.windows.net/";
        public void DeleteImage(int imageId)
        {
            throw new NotImplementedException();
        }
        // Not working right now. Need to check. 
        public IEnumerable<Image> GetImageFileUrl(string productId, string productName, string vendorId)
        {
            string _fileName = vendorId + "-" + productId + "-" + productName + ".jpg";
            AzureBlobStorageService service = new AzureBlobStorageService();
            var check = service.GetFileUrl(_fileName);
            return null;
        }
        public IEnumerable<Image> GetProductImageUrl(string productId, string productName, string vendorId)
        {
            AzureBlobStorageService service = new AzureBlobStorageService();
            throw new NotImplementedException();
        }
        public void InsertImage(IFormFile file)
        {
            AzureBlobStorageService service = new AzureBlobStorageService();
            service.AddImageToBlobStorageAsync(null); 
            throw new NotImplementedException();
        }
        public Task<bool> SaveImage(string pictureName, string pictureBase64, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
