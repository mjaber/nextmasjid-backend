using IbnMasjjed.DomainView;
using IbnMasjjed.DomainView.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IbnMasjjed.Proxy
{
    public interface ICityProxy
    {
        Task<ReturnResult<CityLookupView[]>> GetAll();
        Task<ReturnResult<CityLookupView>> GetById(int Id);
    }

    public class CityProxy: ICityProxy
    {
        private readonly ILogger<CityProxy> _logger;
        private readonly AppSettings _appSettings;

        public CityProxy(ILogger<CityProxy> logger, AppSettings appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        public async Task<ReturnResult<CityLookupView[]>> GetAll()
        {
            var result = new ReturnResult<CityLookupView[]>();

            try
            {
                var apiBaseUrl = _appSettings.ApiConfiguration.BaseUrl; //_config["ApiConfiguration:BaseUrl"];
                var apiKey = _appSettings.ApiConfiguration.Key; //_config["ApiConfiguration:Key"];

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync("api/v1/city");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<ReturnResult<CityLookupView[]>>(responseJson);

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

        public async Task<ReturnResult<CityLookupView>> GetById(int Id)
        {
            var result = new ReturnResult<CityLookupView>();

            try
            {
                var apiBaseUrl = _appSettings.ApiConfiguration.BaseUrl; //_config["ApiConfiguration:BaseUrl"];
                var apiKey = _appSettings.ApiConfiguration.Key; //_config["ApiConfiguration:Key"];

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync($"api/v1/city/{Id}");
                    var responseJson = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<ReturnResult<CityLookupView>>(responseJson);

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
