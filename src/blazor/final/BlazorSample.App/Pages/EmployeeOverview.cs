using BlazorSample.App.Components;
using BlazorSample.App.Services;
using BlazorSample.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorSample.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public EmployeeDataService EmployeeDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeDataService.GetEmployees();
        }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = await EmployeeDataService.GetEmployees();
            StateHasChanged();
        }
    }
}
