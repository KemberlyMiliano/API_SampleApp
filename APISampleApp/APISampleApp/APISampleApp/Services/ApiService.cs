using APISampleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APISampleApp.Services
{
    public class ApiService : IApiService
    {
        public async Task<RandomBeer> GetRandomBeerAsync()
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(Constants.ApiUrl);
            return JsonConvert.DeserializeObject<RandomBeer>(result);
        }
    }
}

