using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MainLibrary.Models;
using System.Text.Json;
using MainLibrary.HttpHelper;

namespace MainLibrary.APICallBuilder
{
    public class BaseTmdbClient
    {
        private readonly string _baseAddress;
        public readonly HttpClient HttpClient;
        private readonly int _apiVersion = 3;
        public string ApiKey { get; set; }
        public BaseTmdbClient(string apiKey, int apiVersion = 3)
        {
            ApiKey = apiKey;
            _apiVersion = apiVersion;
            _baseAddress = "https://api.themoviedb.org/" + $"{_apiVersion}";
            HttpClient = new HttpClient();
        }
        public static BaseTmdbClient GetDefaultDeveloperClient()
        {
            return new BaseTmdbClient("bd334c5a0e089ed0b13eb5d9b0364844"); 
        }
      

        public async Task<HttpResponseMessage> CallGet(RelativeUri inputRelativeUri)
        {
            inputRelativeUri.AddQueryParam("api_key", ApiKey); 
            var httpResponse= await HttpClient.GetAsync( _baseAddress + inputRelativeUri.StringUri);
            Console.WriteLine(_baseAddress + inputRelativeUri.StringUri);
            return httpResponse;
        }
        
        
    }
}