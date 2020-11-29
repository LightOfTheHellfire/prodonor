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
    public class StoreRolesAppService : IApplicationService<StoreRolesDto>
    {
        private readonly IDomainService<StoreRoles> _service;
        private IMapper _mapper;

        public StoreRolesAppService(IMapper mapper, IDomainService<StoreRoles> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<StoreRolesDto> CreateAsync(StoreRolesDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<StoreRolesDto, StoreRoles>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<StoreRoles, StoreRolesDto>(result);
        }

        public async Task UpdateAsync(StoreRolesDto entity)
        {
            var domainEntity = _mapper.Map<StoreRolesDto, StoreRoles>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<StoreRolesDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<StoreRoles, StoreRolesDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<StoreRolesDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<StoreRoles>, IEnumerable<StoreRolesDto>>(result);
        }
    }
}
