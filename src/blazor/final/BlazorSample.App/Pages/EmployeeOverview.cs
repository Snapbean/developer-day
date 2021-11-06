using BlazorSample.App.Services;
using BlazorSample.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorSample.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee>? Employees { get; set; }

        [Inject]
        public EmployeeDataService EmployeeDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeDataService.GetEmployees();
        }
    }
}
