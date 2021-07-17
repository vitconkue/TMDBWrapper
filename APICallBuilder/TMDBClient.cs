using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MainLibrary.Models;
using System.Text.Json;

namespace MainLibrary.APICallBuilder
{
    public class TmdbClient
    {
        private readonly string _baseAddress;
        public readonly HttpClient HttpClient;
        private readonly int _apiVersion = 3;
        public string ApiKey { get; set; }
        public TmdbClient(string apiKey)
        {
            ApiKey = apiKey;
            _baseAddress = "https://api.themoviedb.org/" + $"{_apiVersion}/"; 
            HttpClient = new HttpClient {BaseAddress = new Uri(_baseAddress)}; 
        }
        public static TmdbClient GetDefaultDeveloperClient()
        {
            return new TmdbClient("bd334c5a0e089ed0b13eb5d9b0364844"); 
        }
      

        public async Task<string> CallGetString(string inputRelativeUri)
        {
            string inputRelativeWithAddedApiKey = 
                inputRelativeUri + (inputRelativeUri.Contains("?") ? "&" : "?")  +  $"api_key={ApiKey}"; 
            var httpResponse= await HttpClient.GetAsync(inputRelativeWithAddedApiKey);

            var resultString = await httpResponse.Content.ReadAsStringAsync();

            return resultString;
        }
    }
}