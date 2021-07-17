using System;
using System.Text.Json;
using System.Threading.Tasks;
using MainLibrary.Models;
using MainLibrary.Services.Interfaces;
using MainLibrary.APICallBuilder;

namespace MainLibrary.Services
{
    public class MovieRepository: IBaseEntityRepository<Movie>
    {
        private readonly TmdbClient _client = TmdbClient.GetDefaultDeveloperClient(); 
        
        public async Task<Movie> GetById(int id)
        {
            string relativeUri = "movie/";

            relativeUri += id.ToString();

            var resultString = await _client.CallGetString(relativeUri);
            
            Console.WriteLine(resultString);

            return JsonSerializer.Deserialize<Movie>(resultString);
        }
    }
}