using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Models
{
    public class EntityConfigurationContext : DbContext
    {
        //public DbSet<Settings> Settings { get; set; }

        public EntityConfigurationContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
