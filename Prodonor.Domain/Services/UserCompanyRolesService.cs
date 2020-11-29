using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class UserCompanyRolesService : IDomainService<UserCompanyRoles>
    {
        private readonly IRepository<UserCompanyRoles> _repository;

        public UserCompanyRolesService(IRepository<UserCompanyRoles> repository)
        {
            _repository = repository;
        }

        public async Task<UserCompanyRoles> CreateAsync(UserCompanyRoles entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(UserCompanyRoles entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<UserCompanyRoles> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<UserCompanyRoles>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
