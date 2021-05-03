using System;
using System.Collections.Generic;
using System.Text;

namespace MG.BL.Model
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ContractTypeName { get; private set; }
        public int RoleId { get; private set; }
        public string RoleName { get; private set; }
        public string RoleDescription { get; private set; }
        public decimal HourlySalary { get; private set; }
        public decimal MonthlySalary { get; private set; }
        public decimal AnualSalary {
            get {
                if (ContractTypeName == "HourlySalaryEmployee")
                    return MonthlySalary * 12;
                else if (ContractTypeName == "MonthlySalaryEmployee")
                    return HourlySalary * 12 * 120;
                else
                    return -1;
            }
        }

    }        
}
