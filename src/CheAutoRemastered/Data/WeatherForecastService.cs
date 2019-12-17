using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CheAutoRemastered.Presentation.Models;
using Newtonsoft.Json;

namespace CheAutoRemastered.Presentation.Data
{
    public class WeatherForecastService
    {
        HttpClient _httpClient;
        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public async Task<List<Engine>> GetEngines()
        {
            var response = await _httpClient.GetAsync("http://localhost:51734/Engine");
            return JsonConvert.DeserializeObject<List<Engine>>(await response.Content.ReadAsStringAsync());
        }
    }
}
