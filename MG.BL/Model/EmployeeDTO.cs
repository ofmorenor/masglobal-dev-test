using System;
using System.Collections.Generic;
using System.Text;

namespace MG.BL.Model
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string ContractType { get; set; }
        public string RoleName { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnualSalary { get; set; }
    }
}
