using BL.Model;
using BL.Repository.Contracts;
using BL.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public async Task<IEnumerable<EmployeeDTO>> Get()
        {
            var employees = await _employeeRepository.Get();
            return employees.Select(e => EmployeeDTOFactory.Create(e));
        }

        public async Task<EmployeeDTO> GetById(int id)
        {
            var employee = await _employeeRepository.GetById(id);
            if (employee != null)
            {
                return EmployeeDTOFactory.Create(employee);
            }
            else {
                return null;
            }
        }
    }
}
