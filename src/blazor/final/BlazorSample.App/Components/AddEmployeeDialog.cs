using BlazorSample.App.Services;
using BlazorSample.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorSample.App.Components
{
    public partial class AddEmployeeDialog
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public EmployeeDataService EmployeeDataService { get; set; }

        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee();
        }

        protected async Task HandleValidSubmit()
        {
            Employee.Id = new Random().Next(10, 10000);

            await EmployeeDataService.AddEmployee(Employee);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
