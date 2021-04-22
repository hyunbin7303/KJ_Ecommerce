using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult<Customer> GetCustomer(string customerId)
        //{
        //    var customer = _customerRepository.GetByCustomerAsync(customerId);
        //    // Customer object will have cart Information.
        //    // Cart property will  have all of products that user have chosen.


        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(customer);
        //}
    }
}
// 