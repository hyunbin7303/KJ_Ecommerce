using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ECommerceService.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private ICustomerRepository _customerRepository = null;
        public CustomerController(ICustomerRepository repo)
        {
            _customerRepository = repo ?? null;
        }
        [HttpPost("CreateCustomer")]
        public ActionResult<Customer> CreateCustomer(CreateCustomerDTO createCustomerDTO)
        {
            Customer customer = new Customer();
            customer.Id = createCustomerDTO.UserId;
            
            _customerRepository.InsertAsync(customer);
            // Customer object will have cart Information.
            // Cart property will  have all of products that user have chosen.
            return Ok();
        }
        [HttpGet("customer")]
        public ActionResult<Customer> GetCustomer(string userId)
        {
            var customer = _customerRepository.GetByIdAsync(userId);
            return Ok(customer);
        }
        [HttpPut("customer")]
        public ActionResult<Customer> UpdateCustomer(Customer customer)
        {
            //var customer = _customerRepository.GetByIdAsync(customer.Id);

            return Ok();
        }
    }
}
