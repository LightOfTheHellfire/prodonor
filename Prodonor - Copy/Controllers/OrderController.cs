using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prodonor.Application.Model;
using Prodonor.Application.Services;
using Prodonor.Extensions;

namespace Prodonor.Controllers
{
    [Authorize]
    [ApiController]
    [Route("order")]
    public class OrderController : BaseController
    {
        private IApplicationService<OrderDto> _service;

        public OrderController(IApplicationService<OrderDto> service)
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
        public async Task<IActionResult> Update([FromBody]OrderDto Order)
        {
            return await ExecForResult(() => _service.UpdateAsync(Order));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return await ExecForResult(() => _service.DeleteAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]OrderDto obj)
        {
            var userId = User.GetUserId();
            return await ExecForResult(() => _service.CreateAsync(obj, userId));
        }
    }
}
