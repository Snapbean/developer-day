using BlazorSample.Shared;
using System.Net.Http.Json;

namespace BlazorSample.App.Services
{
    public class EmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("employees");
        }

        public async Task AddEmployee(Employee employee)
        {
            await _httpClient.PostAsJsonAsync("employees", employee);
        }
    }
}
