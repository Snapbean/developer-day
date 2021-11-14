﻿namespace MinimalApi.Services;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GetForecast()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast(
            DateTime.Now.AddDays(index),
            rng.Next(-20, 55),
            Summaries[rng.Next(Summaries.Length)]));
    }
}
