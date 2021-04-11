using ECommerce.Domain.Models;
using ECommerce.Domain.Models.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure
{
    public class OrderCustomBuilder : ICustomModelBuilder
    {
        public void BuildModel(ModelBuilder mb)
        {
            mb.Entity<Address>(x =>
            {
                x.HasOne(d => d.State)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

                x.HasOne(d => d.Country)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            });
            mb.Entity<Order>(x =>
            {
                x.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(200);

                x.Property(e => e.Id).IsRequired();
            });
        }
    }
}
