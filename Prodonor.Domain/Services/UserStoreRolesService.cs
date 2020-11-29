using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class UserStoreRolesService : IDomainService<UserStoreRoles>
    {
        private readonly IRepository<UserStoreRoles> _repository;

        public UserStoreRolesService(IRepository<UserStoreRoles> repository)
        {
            _repository = repository;
        }

        public async Task<UserStoreRoles> CreateAsync(UserStoreRoles entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(UserStoreRoles entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<UserStoreRoles> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<UserStoreRoles>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
