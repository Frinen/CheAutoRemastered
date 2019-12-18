using CheAutoRemastered.Presentation.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;

namespace CheAutoRemastered.Presentation.Pages
{
    public class EnginePageModel : ComponentBase
    {
        [Inject] HttpClient HttpClient { get; set; }
        [Inject] Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        public List<Engine> Engines { get; set; }  = new List<Engine>();
        protected override async Task OnParametersSetAsync()
        {
            await GetEngines();
            await base.OnParametersSetAsync();
        }

        public async Task Delete(Guid id)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "id", id.ToString() }
            };
            var token = await localStorage.GetItemAsync<string>("token");
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await HttpClient.DeleteAsync(QueryHelpers.AddQueryString($"http://localhost:51734/Engine", queryParameters));
            await GetEngines();
        }

        private async Task GetEngines()
        {
            var token = await localStorage.GetItemAsync<string>("token");

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await HttpClient.GetAsync("http://localhost:51734/Engine");
            Engines = JsonConvert.DeserializeObject<List<Engine>>(await response.Content.ReadAsStringAsync());
        }
    }
}
