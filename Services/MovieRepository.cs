using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using MainLibrary.Models;
using MainLibrary.Services.Interfaces;
using MainLibrary.APICallBuilder;
using MainLibrary.HttpHelper;

namespace MainLibrary.Services
{
    public class MovieRepository: IBaseEntityRepository<Movie>
    {
        private readonly BaseTmdbClient _client = BaseTmdbClient.GetDefaultDeveloperClient(); 
        
        public async Task<Movie> GetById(int id)
        {
            RelativeUri relativeUri = new RelativeUri();

            relativeUri.AddNormalParam("movie").AddNormalParam(id.ToString()); 

            var responseMessage = await _client.CallGet(relativeUri);


            string stringResponse = await responseMessage.Content.ReadAsStringAsync(); 

            return JsonSerializer.Deserialize<Movie>(stringResponse);
        }

        public async Task<List<Movie>> GetUpcomingMovie()
        {
            RelativeUri relativeUri = new RelativeUri();
            relativeUri.AddNormalParam("movie").AddNormalParam("upcoming");
            var responseMessage = await _client.CallGet(relativeUri);
            string stringResponse = await responseMessage.Content.ReadAsStringAsync(); 

            
            return JsonSerializer.Deserialize<ListMovieResponse>(stringResponse)?.Movies;

        }
    }
}