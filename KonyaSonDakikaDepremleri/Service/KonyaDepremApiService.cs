using KonyaSonDakikaDepremleri.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KonyaSonDakikaDepremleri.Service
{
    public class KonyaDepremApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public KonyaDepremApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        #region API Request Methods

        public async Task<DepremClass> GetAllEarthquake()
        {
            #region Mesaj İçerik
            var httpRequestMessage = new HttpRequestMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json"),
                RequestUri = new Uri(_configuration["baseUrl"] + "?location=Konya"),
                Method = HttpMethod.Get,
            };
            #endregion

            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);
            var response = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

           return JsonConvert.DeserializeObject<DepremClass>(response); //gelen json verisi ayrıştırılmakta
        }

        #endregion
    }
}
