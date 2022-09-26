using Microsoft.EntityFrameworkCore;
using PP.HiringSystem.Core.@interface.Infastructure;
using RepostaryPattren.Core.Identity;
using RepostaryPattren.Data.Appcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepostaryPattren.Data.Infastructure
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ApplicationDBcontext applicationDBcontext;
        //private DbSet<TEntity> _dbSet;


        public BaseRepository(ApplicationDBcontext applicationDBcontext)
        {
            this.applicationDBcontext = applicationDBcontext;
           // _dbSet = applicationDBcontext.Set<TEntity>();
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await applicationDBcontext.Users.Include(e => e.certificates).Where(e => e.certificates.Count >= 5).ToListAsync();
        }

      



        public async Task CreateUserAsync(User user)
        {
            var users = new User
            {
                AccessFailedCount = user.AccessFailedCount,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                TwoFactorEnabled = user.TwoFactorEnabled,
                LockoutEnabled = user.LockoutEnabled,
            };

           var result= await applicationDBcontext.AddAsync(user);
            await applicationDBcontext.SaveChangesAsync();

        }
    }

}
