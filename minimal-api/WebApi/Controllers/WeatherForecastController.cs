using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastService _forecastService;

        public WeatherForecastController(WeatherForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecast = _forecastService.GetForecast();
            return forecast;
        }
    }
}
