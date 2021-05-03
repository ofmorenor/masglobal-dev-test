using MG.BL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Tests
{
    [TestClass]
    public class MasGlobalIntegrationTests
    {
        [TestMethod]
        public async Task ApiReturnsData()
        {
            var repository = new EmployeeRepositoryMasGlobalApi();
            var employees = await repository.Get();
            Assert.IsTrue(employees.Any());

            var employee = await repository.GetById(1);
            Assert.IsTrue(employee.Id == 1);
        }
    }
}
