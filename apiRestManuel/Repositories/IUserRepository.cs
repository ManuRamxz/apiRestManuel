using apiRestManuel.Models;
using System.Collections.Generic;

namespace apiRestManuel.Repositories
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
