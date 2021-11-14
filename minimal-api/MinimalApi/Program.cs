using MinimalApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<WeatherForecastService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", (WeatherForecastService forecastService) =>
{
    var forecast = forecastService.GetForecast();
    return forecast;
});

app.Run();
