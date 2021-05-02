using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BL.Model
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
                ContractTypeName = employee.ContractTypeName,
                RoleId = employee.RoleId,
                RoleName = employee.RoleName,
                RoleDescription = employee.RoleDescription,
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary
            };

            if (dto.ContractTypeName == CONTRACT_TYPE_MONTHLY)
            {
                dto.AnualSalary = dto.MonthlySalary * 12;
            }
            if (dto.ContractTypeName == CONTRACT_TYPE_HOURLY)
            {
                dto.AnualSalary = dto.HourlySalary * 12 * 120;
            }

            return dto;
        }
    }
}
