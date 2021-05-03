using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MG.BL.Model
{
    public static class EmployeeDTOFactory
    {
        private static readonly string CONTRACT_TYPE_MONTHLY = "MonthlySalaryEmployee";
        private static readonly string CONTRACT_TYPE_HOURLY = "HourlySalaryEmployee";

        public static EmployeeDTO Create(Employee employee)
        {
            var dto = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                RoleName = employee.RoleName,
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary,
                AnualSalary = employee.AnualSalary
            };

            if (employee.ContractTypeName == CONTRACT_TYPE_MONTHLY)
            {
                dto.ContractType = "Monthly";

            }
            if (employee.ContractTypeName == CONTRACT_TYPE_HOURLY)
            {
                dto.ContractType = "Hourly";
            }

            return dto;
        }
    }
}
