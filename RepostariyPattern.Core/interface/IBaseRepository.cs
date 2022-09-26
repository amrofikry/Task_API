namespace PP.HiringSystem.Core.@interface.Infastructure
{
    using RepostaryPattren.Core.Identity;
    using System.Collections.Generic;

    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity> where TEntity : class
    {
      
        Task<IEnumerable<User>> GetAllUserAsync();

        Task CreateUserAsync(User user);

       

    }
}