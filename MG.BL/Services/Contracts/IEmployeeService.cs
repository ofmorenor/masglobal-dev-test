using BL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Contracts
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> Get();
        Task<EmployeeDTO> GetById(int id);
    }
}
