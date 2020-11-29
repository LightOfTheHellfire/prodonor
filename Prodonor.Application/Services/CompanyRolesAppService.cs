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
    public class CompanyRolesAppService : IApplicationService<CompanyRolesDto>
    {
        private readonly IDomainService<CompanyRoles> _service;
        private IMapper _mapper;

        public CompanyRolesAppService(IMapper mapper, IDomainService<CompanyRoles> service)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<CompanyRolesDto> CreateAsync(CompanyRolesDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<CompanyRolesDto, CompanyRoles>(entity);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<CompanyRoles, CompanyRolesDto>(result);
        }

        public async Task UpdateAsync(CompanyRolesDto entity)
        {
            var domainEntity = _mapper.Map<CompanyRolesDto, CompanyRoles>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<CompanyRolesDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<CompanyRoles, CompanyRolesDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<CompanyRolesDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<CompanyRoles>, IEnumerable<CompanyRolesDto>>(result);
        }
    }
}
