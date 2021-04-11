using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Models
{
    public partial class EntityConfigurationContext : DbContext
    {
        //public DbSet<Settings> Settings { get; set; }
        public virtual DbSet<AppMenu> AppMenus { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public EntityConfigurationContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
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
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}
