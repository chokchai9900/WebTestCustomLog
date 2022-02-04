using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTestCustomLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var telemetryClient = new TelemetryClient();
            var rng = new Random();

            MetricTelemetry data = new MetricTelemetry()
            {
                Name = "issue report metrix",
                Sum = rng.Next(0, 99),
                
            };
            data.Properties["txid"] = $"txid01{rng.Next(01, 99)}";
            data.Properties["amount"] = $"{rng.Next(0, 9999999)}";
            data.Properties["phone"] = $"+66{rng.Next(811111111, 999999999)}";
            data.Properties["userId"] = $"testUser{rng.Next(01, 99)}";
            data.Properties["operation"] = "pay";
            telemetryClient.TrackMetric(data);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
