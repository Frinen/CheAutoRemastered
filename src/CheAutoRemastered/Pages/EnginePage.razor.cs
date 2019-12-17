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
        public List<Engine> Engines { get; set; }  = new List<Engine>();
        protected override async Task OnParametersSetAsync()
        {
            var response = await HttpClient.GetAsync("http://localhost:51734/Engine");
            Engines = JsonConvert.DeserializeObject<List<Engine>>(await response.Content.ReadAsStringAsync());
            StateHasChanged();

            await base.OnParametersSetAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            StateHasChanged();
            await base.OnInitializedAsync();
        }
    }
}
