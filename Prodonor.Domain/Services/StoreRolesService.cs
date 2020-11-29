using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class StoreRolesService : IDomainService<StoreRoles>
    {
        private readonly IRepository<StoreRoles> _repository;

        public StoreRolesService(IRepository<StoreRoles> repository)
        {
            _repository = repository;
        }

        public async Task<StoreRoles> CreateAsync(StoreRoles entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(StoreRoles entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<StoreRoles> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<StoreRoles>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
