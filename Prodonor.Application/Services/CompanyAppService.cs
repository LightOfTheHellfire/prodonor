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
    public class CompanyAppService : IApplicationService<CompanyDto>
    {
        private readonly IDomainService<Company> _service;
        private readonly ApplicationUserService _userService;
        private IMapper _mapper;

        public CompanyAppService(IMapper mapper, IDomainService<Company> service, ApplicationUserService userService)
        {
            _service = service;
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<CompanyDto> CreateAsync(CompanyDto entity, int? userId)
        {
            var domainEntity = _mapper.Map<CompanyDto, Company>(entity);
            domainEntity.CompanyRoles = new List<CompanyRoles>();
            var companyRole = new CompanyRoles();
            companyRole.RoleId = 1;
            companyRole.UserCompanyRoles = new List<UserCompanyRoles>() {new UserCompanyRoles() {UserId = (int)userId}};
            domainEntity.CompanyRoles.Add(companyRole);
            var result = await _service.CreateAsync(domainEntity);
            return _mapper.Map<Company, CompanyDto>(result);
        }

        public async Task UpdateAsync(CompanyDto entity)
        {
            var domainEntity = _mapper.Map<CompanyDto, Company>(entity);
            await _service.UpdateAsync(domainEntity);
        }

        public async Task<CompanyDto> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            return _mapper.Map<Company, CompanyDto>(result);
        }

        public async Task DeleteAsync(int id)
        {
            await _service.DeleteAsync(id);
        }

        public async Task<IEnumerable<CompanyDto>> GetAll()
        {
            var result = await _service.GetAll();
            return _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyDto>>(result);
        }
    }
}
