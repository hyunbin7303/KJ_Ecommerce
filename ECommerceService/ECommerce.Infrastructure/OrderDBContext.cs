using ECommerce.Domain.Models.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure
{
    public partial class OrderDBContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public OrderDBContext()
        {
        }
        public OrderDBContext(DbContextOptions<MainEcommerceDBContext> options)
            : base(options)
        {
        }
    }
}
