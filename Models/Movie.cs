using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MainLibrary.Models
{
    public class Movie
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }
        public string backdrop_path { get; set; }
        public List<int> genre_ids { get; set; }
        public int id { get; set; }
        public string media_type { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }

        public override string ToString()
        {
                return $"Adult : {Adult}, Title: {Title}, Vote Average: {vote_average}, Vote Count: {vote_count}"; 
        }
    }
}