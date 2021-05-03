using System;
using System.Collections.Generic;
using System.Text;

namespace MG.BL.Model
{
    public class Employee
    {
        public static readonly string CONTRACT_TYPE_MONTHLY = "MonthlySalaryEmployee";
        public static readonly string CONTRACT_TYPE_HOURLY = "HourlySalaryEmployee";

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string ContractTypeName { get; protected set; }
        public int RoleId { get; protected set; }
        public string RoleName { get; protected set; }
        public string RoleDescription { get; protected set; }
        public decimal HourlySalary { get; protected set; }
        public decimal MonthlySalary { get; protected set; }
        public decimal AnualSalary {
            get {
                return CalculateAnualSalary();
            }
        }

        private decimal CalculateAnualSalary() {
            if (ContractTypeName == CONTRACT_TYPE_MONTHLY)
            {
                return MonthlySalary * 12;
            }
            else if (ContractTypeName == CONTRACT_TYPE_HOURLY)
            {
                return HourlySalary * 12 * 120;
            }
            else { 
                return -1;
            }
        }

    }        
}
