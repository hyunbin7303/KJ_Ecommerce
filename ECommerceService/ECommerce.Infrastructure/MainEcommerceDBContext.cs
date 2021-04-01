using System;
using ECommerce.Domain.Models;
using ECommerce.Domain.Models.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ECommerce.Infrastructure
{
    public partial class MainEcommerceDBContext : DbContext
    {
        public MainEcommerceDBContext()
        {
        }
        public MainEcommerceDBContext(DbContextOptions<MainEcommerceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode).IsRequired();
            });
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_Invoices_CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId);
            });
            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceItems_InvoiceId");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.InvoiceId);
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.OrderId).IsRequired();
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
