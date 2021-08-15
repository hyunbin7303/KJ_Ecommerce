using ECommerce.Core.Models;
using ECommerce.Query;
using System.Threading.Tasks;
namespace ECommerce.Core.Services
{
    public interface ICustomerService
    {
        Task CreateNewCustomer(CreateCustomerDTO newCustomerDTO);
        Task UpdateCustomerInfo(UpdateCustomerDTO updateCustomer);
        Task UpdateAddress(string customerId, string addressId, Address addr);

    }
}
