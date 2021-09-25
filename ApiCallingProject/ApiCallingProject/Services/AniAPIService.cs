using ApiCallingProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Refit;

namespace ApiCallingProject.Services
{
    public class AniAPIService : IAniAPIService
    {
        private IJsonSerializerService serializer = new JsonSerializerService();
        private string baseUrl = "https://api.aniapi.com";
        public async Task<Root> getAnimeSongListAsync()
        {
            var response = await RestService.For<IAniAPI>(baseUrl).GetAnimeSongAsync();

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var animeListResponse = serializer.Deserialize<Root>(responseString);
                return animeListResponse;
            }

            return null;

        }
    }
}
