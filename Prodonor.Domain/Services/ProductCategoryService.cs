using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prodonor.Domain.Model;
using Prodonor.Domain.RepositoryInterfaces;

namespace Prodonor.Domain.Services
{
    public class ProductCategoryService : IDomainService<ProductCategory>
    {
        private readonly IRepository<ProductCategory> _repository;

        public ProductCategoryService(IRepository<ProductCategory> repository)
        {
            _repository = repository;
        }

        public async Task<ProductCategory> CreateAsync(ProductCategory entity)
        {
            return await _repository.Add(entity);
        }

        public async Task UpdateAsync(ProductCategory entity)
        {
            await _repository.SetModified(entity);
        }

        public async Task<ProductCategory> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<IEnumerable<ProductCategory>> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
