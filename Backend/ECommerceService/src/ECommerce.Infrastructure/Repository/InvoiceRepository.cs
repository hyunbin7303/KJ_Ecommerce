using ECommerce.Domain.Models;
using ECommerce.Domain.Models.OrderAggregate;
using ECommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(MainEcommerceDBContext context) : base(context)
        {
        }
    }
}
