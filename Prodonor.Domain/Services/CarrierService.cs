using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class CarrierService : IDomainService<Carrier>
    {
        private readonly IRepository<Carrier> _repository;

        public CarrierService(IRepository<Carrier> repository)
        {
            _repository = repository;
        }

        public async Task<Carrier> CreateAsync(Carrier entity)
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

        public async Task UpdateAsync(Carrier entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Carrier> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Carrier>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
