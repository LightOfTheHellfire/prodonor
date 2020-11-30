﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prodonor.Application.Model;
using Prodonor.Application.Services;

namespace Prodonor.Controllers
{
    [Authorize]
    [ApiController]
    [Route("user-company-roles")]
    public class UserCompanyRolesController : BaseController
    {
        private IApplicationService<UserCompanyRolesDto> _service;

        public UserCompanyRolesController(IApplicationService<UserCompanyRolesDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await ExecForResult(() => _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return await ExecForResult(() => _service.GetAsync(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody]UserCompanyRolesDto UserCompanyRoles)
        {
            return await ExecForResult(() => _service.UpdateAsync(UserCompanyRoles));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ExecForResult(() => _service.DeleteAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]UserCompanyRolesDto obj)
        {
            return await ExecForResult(() => _service.CreateAsync(obj));
        }
    }
}
