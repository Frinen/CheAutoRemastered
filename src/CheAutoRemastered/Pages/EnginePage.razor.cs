using CheAutoRemastered.Presentation.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CheAutoRemastered.Presentation.Pages
{
    public class EnginePageModel : ComponentBase
    {
        [Inject] HttpClient HttpClient { get; set; }
        public List<Engine> Engines { get; set; } 
        protected override async Task OnParametersSetAsync()
        {
            var response = await HttpClient.GetAsync("http://localhost:51734/Engine");
            var Engines = JsonConvert.DeserializeObject<List<Engine>>(await response.Content.ReadAsStringAsync());

            await base.OnParametersSetAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            StateHasChanged();
            await base.OnInitializedAsync();
        }
    }
}
