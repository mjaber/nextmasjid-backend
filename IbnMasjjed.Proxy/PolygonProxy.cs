using IbnMasjjed.DomainView;
using IbnMasjjed.DomainView.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IbnMasjjed.Proxy
{
    public interface IPolygonProxy
    {
        Task<ReturnResult<CityPolygonView[]>> GetByCityId(int cityId);
        Task<ReturnResult<int>> Create(CityPolygonView polygon);
    }

   public  class PolygonProxy: IPolygonProxy
    {
        private readonly ILogger<PolygonProxy> _logger;
        private readonly AppSettings _appSettings;

        public PolygonProxy(ILogger<PolygonProxy> logger, AppSettings appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }


        public async Task<ReturnResult<CityPolygonView[]>> GetByCityId(int cityId)
        {
            var result = new ReturnResult<CityPolygonView[]>();

            try
            {
                var apiBaseUrl = _appSettings.ApiConfiguration.BaseUrl; 
                var apiKey = _appSettings.ApiConfiguration.Key; 

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync($"api/v1/city/{cityId}/Polygon");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<ReturnResult<CityPolygonView[]>>(responseJson);

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, null);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;

            }

            return result;
        }

        public async Task<ReturnResult<int>> Create(CityPolygonView polygon)
        {
            var result = new ReturnResult<int>();

            try
            {
                var apiBaseUrl = _appSettings.ApiConfiguration.BaseUrl;
                var apiKey = _appSettings.ApiConfiguration.Key;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    var json = JsonConvert.SerializeObject(polygon);
                    var payload = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync($"api/v1/Polygon", payload);
                    var responseJson = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<ReturnResult<int>>(responseJson);

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, null);

                result.Errors.Add(ex.Message);
                result.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;

            }

            return result;
        }



    }
}
