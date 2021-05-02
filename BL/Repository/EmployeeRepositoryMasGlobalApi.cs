using BL.Model;
using BL.Repository.Contracts;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BL.Repository
{
    public class EmployeeRepositoryMasGlobalApi : IEmployeeRepository
    {
        private readonly string _apiUrl;
        private RestClient _client;

        public EmployeeRepositoryMasGlobalApi()
        {
            //_apiUrl = apiUrl ?? throw new ArgumentNullException("API URL not provided", nameof(apiUrl));
            _apiUrl = "http://masglobaltestapi.azurewebsites.net/api/";
            _client = new RestClient(_apiUrl);
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            var request = new RestRequest("employees", Method.GET);
            var result = await _client.ExecuteAsync<IEnumerable<Employee>>(request);
            return result.Data;
        }

        public async Task<Employee> GetById(int id)
        {
            var employees = await Get();
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
