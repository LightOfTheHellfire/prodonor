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
    public class UserCompanyRolesAppService : IApplicationService<UserCompanyRolesDto>
    {
        private readonly IDomainService<UserCompanyRoles> _service;
        private IMapper _mapper;

        public UserCompanyRolesAppService(IMapper mapper, IDomainService<UserCompanyRoles> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<UserCompanyRolesDto> CreateAsync(UserCompanyRolesDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<UserCompanyRolesDto, UserCompanyRoles>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<UserCompanyRoles, UserCompanyRolesDto>(result);
        }

        public async Task UpdateAsync(UserCompanyRolesDto entity)
        {
            var domainEntity = _mapper.Map<UserCompanyRolesDto, UserCompanyRoles>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<UserCompanyRolesDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<UserCompanyRoles, UserCompanyRolesDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserCompanyRolesDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<UserCompanyRoles>, IEnumerable<UserCompanyRolesDto>>(result);
        }
    }
}
