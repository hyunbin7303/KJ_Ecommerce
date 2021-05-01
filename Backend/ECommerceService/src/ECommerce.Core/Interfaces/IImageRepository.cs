using ECommerce.Core.Models.ProductAggregate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IImageRepository
    {
        IEnumerable<Image> GetImageFileUrl(string productId, string productName, string vendorId);
        void InsertImage(IFormFile file);
        void DeleteImage(int imageId);
        Task<bool> SaveImage(string pictureName, string pictureBase64, CancellationToken cancellationToken);
    }
}
