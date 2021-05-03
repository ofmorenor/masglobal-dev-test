using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MG.BL.Model;
using MG.BL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.Logging;

namespace MG.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(
            ILogger<EmployeeController> logger,
            IEmployeeService employeeService
        )
        {
            _logger = logger;
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employees = await _employeeService.Get();
                return Ok(employees);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var employee = await _employeeService.GetById(id);
                if (employee == null) { 
                    return NotFound(new { Code = 404, Message = $"Employee {id} not found" });
                }
                return Ok(employee);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        private IActionResult InternalServerError(Exception e) { 
            return StatusCode(500, 
                new { 
                    Code = 500, 
                    Message = "Something went wrong.", 
                    DebugMessage = $"ExceptionMessage: {e.Message} - {e.InnerException?.Message} - ${e.StackTrace}"
                });
        }
    }
}
