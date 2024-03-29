﻿using System;
using ECommerce.Core.Models;
using ECommerce.Core.Models.CartAggregate;
using ECommerce.Core.Models.OrderAggregate;
using ECommerce.Core.Models.ProductAggregate;
using ECommerce.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AppMenu> AppMenus { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<Core.Models.ProductAggregate.Attribute> Attributes { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<VendorProduct> ProductVendors { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.ApplyConfiguration(new ApplicationSettingConfiguration());
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Address");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.AddressType).HasMaxLength(25);
                entity.Property(e => e.ContactName).HasMaxLength(100);
                entity.Property(e => e.Address1).HasMaxLength(100);
                entity.Property(e => e.Address2).HasMaxLength(100);
                entity.Property(e => e.City).HasMaxLength(50);
                entity.Property(e => e.Country).HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(200);
                entity.Property(e => e.Phone).HasMaxLength(50);
                entity.Property(e => e.Province).HasMaxLength(50);
                entity.Property(e => e.PostalCode).HasMaxLength(50);
            });
            modelBuilder.Entity<AppMenu>(entity =>
            {
                entity.ToTable("App_Menu");

                entity.Property(e => e.Id).HasMaxLength(200);
                entity.Property(e => e.Availability).HasMaxLength(20);
                entity.Property(e => e.Description).HasMaxLength(450);
                entity.Property(e => e.MenuName).HasMaxLength(300);
                entity.Property(e => e.MenuType)
                    .HasMaxLength(4)
                    .IsUnicode(false);
                entity.Property(e => e.ParentId).HasMaxLength(200);
                entity.Property(e => e.UsedBy).HasMaxLength(100);
                entity.Property(e => e.Visibility).HasMaxLength(20);
            });
            modelBuilder.Entity<Core.Models.ProductAggregate.Attribute>(entity =>
            {
                entity.ToTable("Attribute");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.AttributeName)
                    .HasMaxLength(200)
                    .HasColumnName("attribute_name");
                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("attribute_value");
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("description");
            });
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.VendorId).HasMaxLength(100);
                entity.Property(e => e.CartStatus).HasMaxLength(50);
                entity.Property(e => e.CartType).HasMaxLength(50);
                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(100);
            });
            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("CartItem");
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.CartId).HasMaxLength(100);
                entity.Property(e => e.CouponCode).HasMaxLength(20);
                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");
                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");
                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK_CartId");
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Type).HasMaxLength(100);
                entity.Property(e => e.ParentId).HasColumnName("ParentId");
                entity.Property(e => e.Description).HasMaxLength(100);
                entity.Property(e => e.Active);
            });
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("customer_name");
            });
            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.ImageTitle).HasMaxLength(100);
                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(450)
                    .HasColumnName("ImageURL");
            });
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");
                entity.Property(e => e.CustomerId).HasMaxLength(100);
                entity.Property(e => e.CustomerNote).HasMaxLength(1000);
                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.PaymentId)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.ShipmentId)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.ShippingTotal).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VAT");
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.CartId).HasMaxLength(100);
                entity.Property(e => e.Comment).HasMaxLength(200);
                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Status).HasMaxLength(2);
                entity.HasMany(o => o.OrderItems)
                    .WithOne(i => i.Order)
                    .HasForeignKey(i => i.OrderId);
            });
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");
                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderId");
                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.OrderItems)
                //    .HasForeignKey(d => d.ProductId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ProductId");
            });
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.InvoiceId).HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TrnCode)
                    .IsRequired()
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.DisplayName).HasMaxLength(255);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.ProductType).IsRequired().HasMaxLength(25);
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorId");
            });
            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttribute_ProudctId");
            });
            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.Comment).HasMaxLength(450);
                entity.Property(e => e.Title).HasMaxLength(100);
            });
            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(450);
                entity.Property(e => e.TrackingNumber).HasMaxLength(450);
            });
            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.Note).HasMaxLength(500).IsUnicode(false).HasColumnName("note");
                entity.Property(e => e.PhoneNumber) .HasMaxLength(50);
                entity.Property(e => e.VendorName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DisplayName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DomainUser).IsRequired().HasMaxLength(50);
                entity.Property(e => e.CreateBy).HasMaxLength(50);
                entity.Property(e => e.VendorType).HasMaxLength(25);
                entity.Property(e => e.Website).HasMaxLength(50);
            });
            modelBuilder.Entity<VendorProduct>(entity =>
            {
                entity.ToTable("ProductVendor");
                entity.HasKey(pv => new { pv.ProductId, pv.VendorId });
            });
            modelBuilder.Entity<VendorProduct>(entity =>
            {
                entity.HasOne(pv => pv.Product)
                .WithMany(p => p.ProductVendors)
                .HasForeignKey(pv => pv.ProductId);
            });
            modelBuilder.Entity<VendorProduct>(entity =>
            {
                entity.HasOne(pv => pv.Vendor)
                .WithMany(p => p.VendorProducts)
                .HasForeignKey(pv => pv.VendorId);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Account).HasMaxLength(100).IsUnicode(false).HasColumnName("Account");
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EmailVerified).ValueGeneratedNever().HasDefaultValue(null);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Address2).HasMaxLength(100);
                entity.Property(e => e.Country).HasMaxLength(50);
                entity.Property(e => e.ZipCode).HasMaxLength(20);
                entity.Property(e => e.IsActive).ValueGeneratedNever().HasDefaultValue(null);
                entity.Property(e => e.PhoneNumber).HasMaxLength(50);
                entity.Property(e => e.VendorId);
                entity.Property(e => e.Description).HasMaxLength(400);
            });

            //modelBuilder.Entity<UserVendor>(entity =>
            //{
            //    entity.ToTable("UserVendor");
            //    entity.HasKey(pv => new { pv.UserId, pv.VendorId });
            //});
            //modelBuilder.Entity<UserVendor>()
            //    .HasOne(u => u.User)
            //    .WithMany(u =>u.UserVendors)
            //    .HasForeignKey(u => u.UserId)
            //    .IsRequired().OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UserVendor>()
            //    .HasOne(v => v.Vendor)
            //    .WithMany(v => v.UserVendors)
            //    .HasForeignKey(v => v.VendorId)
            //    .IsRequired().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.AddressId).HasMaxLength(450);
                entity.Property(e => e.Description).HasMaxLength(100);
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
            //SeedDataInsert(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        private void SeedDataInsert(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasData(new Address { Id = 1, ContactName = "Kevin Park", Address1 = "8 solidarity Crt", AddressType = "Home", City = "Brampton", Country = "Canada", Province = "Ontario", Phone = "519-721-5349" });
            modelBuilder.Entity<Vendor>()
                .HasData(new Vendor { Id = 1, VendorName = "KevinStore", DisplayName = "Kevin Bicycle Store", DomainUser = "kevin1234", CreateBy = "Kevin1234", VendorType = "Ecommerce", AddressId = 1, PhoneNumber = "519-123-4567", Website = "hyunbin7303@gmail.com", Note = "Kevin Sampel Data." });
        }
    }



    public class CartConfigurqation : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class ApplicationSettingConfiguration : IEntityTypeConfiguration<AppSetting>
    {
        public void Configure(EntityTypeBuilder<AppSetting> builder)
        {
            builder.ToTable("AppSetting");
            builder.Property(e => e.Id).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(450);
            builder.Property(e => e.Module).HasMaxLength(300);
            builder.Property(e => e.Value).HasMaxLength(300);
        }
    }
}
