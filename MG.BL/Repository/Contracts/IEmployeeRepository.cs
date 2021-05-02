using BL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repository.Contracts
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<IEnumerable<Employee>> Get();
    }
}
