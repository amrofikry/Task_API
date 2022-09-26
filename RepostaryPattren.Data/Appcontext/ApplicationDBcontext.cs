using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepostaryPattren.Core.Entities;
using RepostaryPattren.Core.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RepostaryPattren.Data.Appcontext
{
    public class ApplicationDBcontext: IdentityDbContext<User>
    {
        public ApplicationDBcontext()
        {

        }

        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }
        public virtual DbSet<certificate> certificates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .ToTable("User")
                .Ignore(e => e.PhoneNumberConfirmed)
                .Ignore(e => e.EmailConfirmed)
                .Ignore(e => e.AccessFailedCount)
                .Ignore(e => e.ConcurrencyStamp)
                .Ignore(e => e.NormalizedUserName)
                .Ignore(e => e.TwoFactorEnabled)
                .Ignore(e => e.LockoutEnd)
                .Ignore(e => e.LockoutEnabled);
                
                
              



          

        }
    }
}
