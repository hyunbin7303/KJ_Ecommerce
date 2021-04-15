using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class ImageController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
