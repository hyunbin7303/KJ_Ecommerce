﻿using System;
using ECommerce.Domain.Models;
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
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MainEcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Category");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.ImageAddress).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProductFormat).HasMaxLength(50);

                entity.Property(e => e.UnitsInStock).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
