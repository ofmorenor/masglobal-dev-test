using MG.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MG.BL.Tests.Mocks
{
    public class MockEmployee:Employee
    {
        public MockEmployee(string contractType, decimal monthlySalary, decimal hourlySalary)
        {
            ContractTypeName = contractType; 
            MonthlySalary = monthlySalary; 
            HourlySalary = hourlySalary; 
        }
    }
}
