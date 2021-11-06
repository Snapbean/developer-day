using BlazorSample.Shared;
using System.Text.Json;

namespace BlazorSample.App.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }

    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            using var employeeStream = await _httpClient.GetStreamAsync("employees");
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(employeeStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
