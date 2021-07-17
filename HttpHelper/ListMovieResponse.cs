using System.Collections.Generic;
using System.Text.Json.Serialization;
using MainLibrary.Models;

namespace MainLibrary.HttpHelper
{
    public class ListMovieResponse
    {
       
            public int page { get; set; }
            [JsonPropertyName("results")]
            public List<Movie> Movies { get; set; }
    }
}