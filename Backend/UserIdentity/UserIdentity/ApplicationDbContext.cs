using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UserIdentity
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EcRole> EcRoles { get; set; }
        public virtual DbSet<EcRoleClaim> EcRoleClaims { get; set; }
        public virtual DbSet<EcUser> EcUsers { get; set; }
        public virtual DbSet<EcUserClaim> EcUserClaims { get; set; }
        public virtual DbSet<EcUserLogin> EcUserLogins { get; set; }
        public virtual DbSet<EcUserRole> EcUserRoles { get; set; }
        public virtual DbSet<EcUserToken> EcUserTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<EcRole>(entity =>
            {
                entity.ToTable("EC_Roles");
                entity.Property(e => e.Id).HasMaxLength(256);
                entity.Property(e => e.Name).HasMaxLength(256);
                entity.Property(e => e.NormalizedName).HasMaxLength(256);
                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(256);
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
                //entity.Property(e => e.FirstName).HasMaxLength(256);
                //entity.Property(e => e.LastName).HasMaxLength(256);

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
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
