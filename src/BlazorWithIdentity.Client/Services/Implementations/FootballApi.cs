using BlazorWithIdentity.Client.Services.Contracts;
using BlazorWithIdentity.Shared.DTO.Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Client.Services.Implementations
{
    public class FootballApi : IFootballDataService
    {
        private readonly HttpClient _httpClient;

        public FootballApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        string FootballBaseUrl = "https://www.scorebat.com/video-api/v3";

      

        public async Task<FootballResultDTO<FootballDataDTO>> GetFootballData()
        {
            var data = await _httpClient.GetFromJsonAsync<FootballResultDTO<FootballDataDTO>>(FootballBaseUrl);
            return data;
        }

       

      

       
    }
}
