using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserIdentity.Controllers;

namespace UserIdentity
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [Authorize]
        public ActionResult Get()
        { 
            return Ok("Works");
        }



    } 
}
