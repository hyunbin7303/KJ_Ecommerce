using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class OrderController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult<Order> Post(int shoppingCartId)
        //{
        //    var cart = _cartServoces.(shoppingCartId);
        //    // Cart object will have all of the prodcucts.

        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(customer);
        //}
    }
}
