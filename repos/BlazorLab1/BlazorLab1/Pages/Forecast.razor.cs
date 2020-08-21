using BlazorLab1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorLab1.Pages
{
    public partial class Forecast
    {
        //[Inject] public ILogger logger  { get; set; }
        private WeatherForecast[] forecasts;

        protected override void OnInitialized()
        {
            var rng = new Random();
            forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        private static readonly string[] Summaries = new[]
        {
            "Cloudy","Rainy","Sunny","Snowy"
        };

        //protected void DemoLogging()
        //{
        //    logger.LogTrace("Logger: Trace");
        //    logger.LogDebug("Logger: Debug");
        //    logger.LogInformation("Logger: Information");
        //    logger.LogWarning("Logger: Warning");
        //    logger.LogError("Logger: Error");
        //    logger.LogCritical("Logger: Critical");
        //    logger.Log(LogLevel.None, "Logger: None");
        //}
    }
}
