using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prodonor.Application.Model;
using Prodonor.Domain.Model;
using Prodonor.Domain.Services;

namespace Prodonor.Application.Services
{
    public class ProductCategoryAppService : IApplicationService<ProductCategoryDto>
    {
        private readonly IDomainService<ProductCategory> _service;
        private IMapper _mapper;

        public ProductCategoryAppService(IMapper mapper, IDomainService<ProductCategory> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<ProductCategoryDto> CreateAsync(ProductCategoryDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<ProductCategoryDto, ProductCategory>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<ProductCategory, ProductCategoryDto>(result);
        }

        public async Task UpdateAsync(ProductCategoryDto entity)
        {
            var domainEntity = _mapper.Map<ProductCategoryDto, ProductCategory>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<ProductCategoryDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<ProductCategory, ProductCategoryDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryDto>>(result);
        }
    }
}
