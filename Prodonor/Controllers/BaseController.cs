using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prodonor.Controllers
{
    public class BaseController : Controller
    {

        protected async Task<IActionResult> ExecForResult<TResult>(Func<Task<TResult>> action)
        {
            var actionResult = default(IActionResult);
            if (!ModelState.IsValid)
            {
                actionResult = WriteModelStateErrors();
            }
            else try
                {
                    TResult result = await action();
                    actionResult = Json(result);
                    Response.StatusCode = StatusCodes.Status200OK;
                }
                catch (Exception e)
                {
                    Response.StatusCode = StatusCodes.Status500InternalServerError;
                    actionResult = Json($"Server error occured {e.Message}");
                }

            return await Task.FromResult(actionResult);
        }
        protected async Task<IActionResult> ExecForResult<TResult>(Func<Task> action)
        {
            var actionResult = default(IActionResult);
            if (!ModelState.IsValid)
            {
                actionResult = WriteModelStateErrors();
            }
            else try
                {
                    await action();
                    actionResult = Ok();
                    Response.StatusCode = StatusCodes.Status200OK;
                }
                catch (Exception e)
                {
                    Response.StatusCode = StatusCodes.Status500InternalServerError;
                    actionResult = Json($"Server error occured {e.Message}");
                }

            return await Task.FromResult(actionResult);
        }
        protected async Task<IActionResult> ExecForResult<TResult>(Func<TResult> action)
        {
            var actionResult = default(IActionResult);
            if (!ModelState.IsValid)
            {
                actionResult = WriteModelStateErrors();
            }
            else try
                {
                    TResult result = action();
                    actionResult = Json(result);
                    Response.StatusCode = StatusCodes.Status200OK;
                }
                catch (Exception e)
                {
                    Response.StatusCode = StatusCodes.Status500InternalServerError;
                    actionResult = Json($"Server error occured {e.Message}");
                }

            return await Task.FromResult(actionResult);
        }
        protected async Task<IActionResult> ExecForResult<TResult>(Action action)
        {
            var actionResult = default(IActionResult);
            if (!ModelState.IsValid)
            {
                actionResult = WriteModelStateErrors();
            }
            else try
                {
                    action();
                    actionResult = Ok();
                    Response.StatusCode = StatusCodes.Status200OK;
                }
                catch (Exception e)
                {
                    Response.StatusCode = StatusCodes.Status500InternalServerError;
                    actionResult = Json($"Server error occured {e.Message}");
                }

            return await Task.FromResult(actionResult);
        }

        protected IActionResult WriteModelStateErrors()
        {
            List<string> errors = new List<string>();
            foreach (var state in ModelState)
            {
                errors.AddRange(state.Value.Errors.Select(e => e.ErrorMessage != String.Empty ? e.ErrorMessage : e.Exception.Message));
            }

            return StatusCode(StatusCodes.Status400BadRequest, errors);
        }
    }
}
