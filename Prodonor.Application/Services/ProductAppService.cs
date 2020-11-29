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
    public class ProductAppService : IApplicationService<ProductDto>
    {
        private readonly IDomainService<Product> _service;
        private IMapper _mapper;

        public ProductAppService(IMapper mapper, IDomainService<Product> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateAsync(ProductDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<ProductDto, Product>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Product, ProductDto>(result);
        }

        public async Task UpdateAsync(ProductDto entity)
        {
            var domainEntity = _mapper.Map<ProductDto, Product>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Product, ProductDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(result);
        }
    }
}
