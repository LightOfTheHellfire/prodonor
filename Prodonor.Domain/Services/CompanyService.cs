using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class CompanyService : IDomainService<Company>
    {
        private readonly IRepository<Company> _repository;

        public CompanyService(IRepository<Company> repository)
        {
            _repository = repository;
        }

        public async Task<Company> CreateAsync(Company entity)
        {
            try
            {
                return await _repository.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(Company entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Company> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
