using CVProject.Models.Entity;
using CVProject.Models.Entity.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVProject.Models.DataContext
{
    public class CVDbContext : IdentityDbContext<AppUser,AppRole,int,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        public CVDbContext(DbContextOptions options)
          : base(options)
        {
        }


        #region Membership
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUserClaim> UserClaims { get; set; }
        public DbSet<AppUserRole> UserRoles{ get; set; }
        public DbSet<AppUserLogin> UserLogins { get; set; }
        public DbSet<AppRoleClaim> RoleClaims { get; set; }
        public DbSet<AppUserToken> UserTokens { get; set; }
        #endregion


        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AppInfo> AppInfos { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>(e =>
            {
                e.Property(p => p.CreatedDate)
                .HasDefaultValueSql("dateadd(hour,4,getutcdate())");
                //.HasDefaultValue(DateTime.Now);
            });

        }

    }
}
