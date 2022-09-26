using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using ReapsotritPattren.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReapsotritPattren.Data_.Appcontext
{
    public class ApplicationDBcontext: IdentityDbContext
    {


        public ApplicationDBcontext()
        {
        }

        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<User>().ToTable("User", "Security");
            //builder.Entity<Role>().ToTable("Role", "Security");
            //builder.Entity<UserRole>().ToTable("UserRole", "Security");
            //builder.Entity<UserClaim>().ToTable("UserClaim", "Security");
            //builder.Entity<UserLogin>().ToTable("UserLogin", "Security");
            //builder.Entity<RoleClaim>().ToTable("RoleClaim", "Security");
            //builder.Entity<UserToken>().ToTable("UserToken", "Security");
        }
    }
}
