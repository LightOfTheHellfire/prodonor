using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;

namespace Prodonor.Domain.RepositoryInterfaces
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetByNameAsync(string username);
    }
}
