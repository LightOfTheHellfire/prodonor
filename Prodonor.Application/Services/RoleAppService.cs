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
    public class RoleAppService : IApplicationService<RoleDto>
    {
        private readonly IDomainService<Role> _service;
        private IMapper _mapper;

        public RoleAppService(IMapper mapper, IDomainService<Role> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<RoleDto> CreateAsync(RoleDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<RoleDto, Role>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Role, RoleDto>(result);
        }

        public async Task UpdateAsync(RoleDto entity)
        {
            var domainEntity = _mapper.Map<RoleDto, Role>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<RoleDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Role, RoleDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<RoleDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Role>, IEnumerable<RoleDto>>(result);
        }
    }
}
