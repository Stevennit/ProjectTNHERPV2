using Hiver.Data.Configurations;
using Hiver.Data.Entities;
using Hiver.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.EF
{
    public class HiverDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public HiverDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API

            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.ApplyConfiguration(new AppControllerConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleControllerConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleControllerGroupConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }


        public DbSet<AppController> AppControllers { set; get; }
        public DbSet<AppRoleController> AppRoleControllers { set; get; }
        public DbSet<AppRoleControllerGroup> AppRoleControllerGroups { set; get; }

        public DbSet<Menu> Menus { set; get; }

    }
}