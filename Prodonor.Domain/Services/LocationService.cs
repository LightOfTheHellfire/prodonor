using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class LocationService : IDomainService<Location>
    {
        private readonly IRepository<Location> _repository;

        public LocationService(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<Location> CreateAsync(Location entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(Location entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<Location> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Location>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
