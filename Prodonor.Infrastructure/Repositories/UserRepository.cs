using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;
using Prodonor.Infrastructure.Model;

namespace Prodonor.Infrastructure.Repositories
{
    public class UserRepository: BaseRepository<User, UserDao>, IUserRepository
    {
        public UserRepository(ProdonorDbContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public Task<User> GetByNameAsync(string username)
        {
            return Task.FromResult(Mapper.Map<UserDao, User>(Entities.SingleOrDefault(e => e.Username == username)));
        }
    }
}
