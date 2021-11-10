using BlazorSample.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("Open");

var employees = new List<Employee>
{
    new Employee{Id = 1, FirstName = "Sara", LastName = "Meier", IsActive = true},
    new Employee{Id = 2, FirstName = "Daniel", LastName = "Mock", IsActive = true},
    new Employee{Id = 3, FirstName = "Bettina", LastName = "Luginbühl", IsActive = false}
};

app.MapGet("/employees", () =>
{
    return employees;
});

app.MapGet("/employees/{id}", (int id) => 
{ 
    return employees.SingleOrDefault(x => x.Id == id); 
});

app.MapPost("/employees", (Employee employee) =>
{
    employees.Add(employee);
});

app.Run();
