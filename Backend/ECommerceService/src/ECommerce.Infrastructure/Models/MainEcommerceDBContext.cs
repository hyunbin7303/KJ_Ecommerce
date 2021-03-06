﻿using System;
using ECommerce.Domain.Models;
using ECommerce.Domain.Models.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ECommerce.Infrastructure.Models
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
        public virtual DbSet<Domain.Models.Attribute> Attributes { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EcRole> EcRoles { get; set; }
        public virtual DbSet<EcRoleClaim> EcRoleClaims { get; set; }
        public virtual DbSet<EcUser> EcUsers { get; set; }
        public virtual DbSet<EcUserClaim> EcUserClaims { get; set; }
        public virtual DbSet<EcUserLogin> EcUserLogins { get; set; }
        public virtual DbSet<EcUserRole> EcUserRoles { get; set; }
        public virtual DbSet<EcUserToken> EcUserTokens { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;User ID=sa;Password=Cc7594435;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Address");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Province).HasMaxLength(50);
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
            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.ToTable("AppSetting");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.Property(e => e.Module).HasMaxLength(300);

                entity.Property(e => e.Value).HasMaxLength(300);
            });
            modelBuilder.Entity<Domain.Models.Attribute>(entity =>
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
            });
            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("CartItem");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CartId).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");

                //entity.HasOne(d => d.Cart)
                //    .WithMany(p => p.CartItems)
                //    .HasForeignKey(d => d.CartId)
                //    .HasConstraintName("FK_CartId");
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
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
            modelBuilder.Entity<EcRole>(entity =>
            {
                entity.ToTable("EC_Roles");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });
            modelBuilder.Entity<EcRoleClaim>(entity =>
            {
                entity.ToTable("EC_RoleClaims");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EcRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });
            modelBuilder.Entity<EcUser>(entity =>
            {
                entity.ToTable("EC_Users");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });
            modelBuilder.Entity<EcUserClaim>(entity =>
            {
                entity.ToTable("EC_UserClaims");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EcUserClaims)
                    .HasForeignKey(d => d.UserId);
            });
            modelBuilder.Entity<EcUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("EC_UserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EcUserLogins)
                    .HasForeignKey(d => d.UserId);
            });
            modelBuilder.Entity<EcUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("EC_UserRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EcUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EcUserRoles)
                    .HasForeignKey(d => d.UserId);
            });
            modelBuilder.Entity<EcUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("EC_UserTokens");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EcUserTokens)
                    .HasForeignKey(d => d.UserId);
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

                entity.Property(e => e.Status).HasMaxLength(1);
            });
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Unit).HasMaxLength(10);
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

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentMethodId");
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

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.Property(e => e.DisplayName).HasMaxLength(450);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryId");

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

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ProductAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttribute_AttributeId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttribute_ProudctId");
            });
            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductImage");
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

                entity.Property(e => e.LastUpdatedtime)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("last_updatedtime");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("website");
            });
            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressId).HasMaxLength(450);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
