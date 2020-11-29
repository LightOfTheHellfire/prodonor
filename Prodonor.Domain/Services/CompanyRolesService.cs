using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class CompanyRolesService : IDomainService<CompanyRoles>
    {
        private readonly IRepository<CompanyRoles> _repository;

        public CompanyRolesService(IRepository<CompanyRoles> repository)
        {
            _repository = repository;
        }

        public async Task<CompanyRoles> CreateAsync(CompanyRoles entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(CompanyRoles entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<CompanyRoles> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<CompanyRoles>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
