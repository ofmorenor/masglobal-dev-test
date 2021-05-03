using MG.BL.Model;
using MG.BL.Repository;
using MG.BL.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public async Task CalculatesAnualSalaryMonthlyPaid()
        {
            // Arrange
            var employee = new MockEmployee(Employee.CONTRACT_TYPE_MONTHLY, 1, 0);
            // Act
            var result = employee.AnualSalary;
            var expected = 12;
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public async Task CalculatesAnualSalaryHourlyPaid()
        {
            // Arrange
            var employee = new MockEmployee(Employee.CONTRACT_TYPE_HOURLY, 0, 1);
            var expected = 1440;
            // Act
            var result = employee.AnualSalary;
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
