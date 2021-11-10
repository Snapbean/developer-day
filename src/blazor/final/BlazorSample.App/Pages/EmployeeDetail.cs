using BlazorSample.App.Services;
using BlazorSample.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorSample.App.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public EmployeeDataService EmployeeDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetail(EmployeeId);
        }
    }
}
