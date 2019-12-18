using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CheAutoRemastered.Presentation.Models;
using CheAutoRemastered.Presentation.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace CheAutoRemastered.Presentation.Pages
{
    public class IndexModel : ComponentBase
    {
        [Inject] private HttpClient HttpClient { get; set; }
        [Inject] Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }

        public async Task Login()
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "email", Email },
                { "password", Password }
            };

            var t = new FormUrlEncodedContent(queryParameters);
            var response = await HttpClient.GetAsync($"http://localhost:51734/Authenticate/login?email={Email}&password={Password}");
            var r = JsonConvert.DeserializeObject<LoginModel>(await response.Content.ReadAsStringAsync());
            await localStorage.SetItemAsync("token", r.Token);
            LoggedIn = true;
        }

        public async Task Register()
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "email", Email },
                { "password", Password }
            };

            var t = new FormUrlEncodedContent(queryParameters);
            var response = await HttpClient.PostAsync($"http://localhost:51734/Authenticate/register?email={Email}&password={Password}", new StringContent(""));
            try
            {
                var r = JsonConvert.DeserializeObject<LoginModel>(await response.Content.ReadAsStringAsync());
                await localStorage.SetItemAsync("token", r.Token);
                LoggedIn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

    }
}
