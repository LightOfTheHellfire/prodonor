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
    public class UserStoreRolesAppService : IApplicationService<UserStoreRolesDto>
    {
        private readonly IDomainService<UserStoreRoles> _service;
        private IMapper _mapper;

        public UserStoreRolesAppService(IMapper mapper, IDomainService<UserStoreRoles> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<UserStoreRolesDto> CreateAsync(UserStoreRolesDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<UserStoreRolesDto, UserStoreRoles>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<UserStoreRoles, UserStoreRolesDto>(result);
        }

        public async Task UpdateAsync(UserStoreRolesDto entity)
        {
            var domainEntity = _mapper.Map<UserStoreRolesDto, UserStoreRoles>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<UserStoreRolesDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<UserStoreRoles, UserStoreRolesDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserStoreRolesDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<UserStoreRoles>, IEnumerable<UserStoreRolesDto>>(result);
        }
    }
}
