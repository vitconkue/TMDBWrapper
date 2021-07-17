using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MainLibrary.APICallBuilder
{
    public class TmdbClient
    {
        private readonly string _baseAddress = "https://api.themoviedb.org/3/";

        public TmdbClient(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public async Task<string> TestCall()
        {
            var newClient = new HttpClient {BaseAddress = new Uri(_baseAddress)};
            var result = await newClient.GetAsync("movie/76341");

            return result.ToString();
        }
    }
}