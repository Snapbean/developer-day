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
    new(1, "Sara", "Meier", "Z�rich", true),
    new(2, "Daniel", "Mock", "Bern", true),
    new(3, "Bettina", "Luginb�hl", "Bern", false),
};

app.MapGet("/employees", () =>
{
    return employees;
});

app.MapPost("/employees", (Employee employee) =>
{
    employees.Add(employee);
});

app.Run();
