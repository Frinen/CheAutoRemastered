using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CheAutoRemastered.Presentation.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace CheAutoRemastered.Presentation.Pages
{
    public class CreateEnginePageModel : ComponentBase
    {
        public EngineCreateModel Engine { get; set; } = new EngineCreateModel();
        [Inject] Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [Inject] private HttpClient HttpClient { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        public async Task Create()
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(Engine), Encoding.UTF8, "application/json");
            var token = await localStorage.GetItemAsync<string>("token");

            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await HttpClient.PostAsync("http://localhost:51734/Engine", stringContent);
            NavigationManager.NavigateTo("/Engines");
        }
    }
}
