using BlazorSample.App;
using BlazorSample.App.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:44326/"));

await builder.Build().RunAsync();
