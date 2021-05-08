using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{

    public class ImageController : BaseController
    {
        [HttpPost("UploadFile")]
        public async Task<string> UploadFile([FromForm]IFormFile file)
        {
            string fName = file.FileName;
            //string path = Path.Combine(hostingEnvironment.ContentRootPath, "Images/" + file.FileName);
            //using (var stream = new FileStream(path, FileMode.Create))
            //{
            //    await file.CopyToAsync(stream);
            //}
            return file.FileName;
        }
    }
}
