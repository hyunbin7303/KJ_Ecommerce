using System;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace UserIdentity
{
    public partial class ApplicationDbContext : IdentityDbContext<EcUser,IdentityRole<string>,string>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IdentityRole<string>> EcRoles { get; set; }
        public virtual DbSet<IdentityRoleClaim<string>> EcRoleClaims { get; set; }
        public virtual DbSet<EcUser> EcUsers { get; set; }
        public virtual DbSet<IdentityUserClaim<string>> EcUserClaims { get; set; }
        public virtual DbSet<IdentityUserLogin<string>> EcUserLogins { get; set; }
        public virtual DbSet<IdentityUserRole<string>> EcUserRoles { get; set; }
        public virtual DbSet<IdentityUserToken<string>> EcUserTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString =configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<EcUser>(entity => { 
                entity.ToTable(name: "EC_Users"); 
            });
            modelBuilder.Entity<IdentityRole<string>>(entity => {entity.ToTable(name : "EC_Roles");});
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => {entity.ToTable(name : "EC_RoleClaims");});
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            { 
                entity.ToTable(name: "EC_UserClaims");
                entity.Property(e => e.UserId).IsRequired().HasMaxLength(450);
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>{entity.ToTable(name: "EC_UserLogins");});
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable(name: "EC_UserRoles");});
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>{entity.ToTable(name: "EC_UserTokens");});
        }

    }
}
