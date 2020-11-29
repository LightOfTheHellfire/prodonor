using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class RoleService : IDomainService<Role>
    {
        private readonly IRepository<Role> _repository;

        public RoleService(IRepository<Role> repository)
        {
            _repository = repository;
        }

        public async Task<Role> CreateAsync(Role entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(Role entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Role> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
