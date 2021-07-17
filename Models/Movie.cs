namespace MainLibrary.Models
{
    public class Movie
    {
        public  bool adult { get; set; }
        public string title  {get; set; }

        public double vote_average {get; set; }

        public int vote_count {get; set; }
        
        public double popularity { get; set; }
        
        public string idmb_id { get; set; }
        
        public string poster_path { get; set; }

        public override string ToString()
        {
                return $"Adult : {adult}, Title: {title}, Vote Average: {vote_average}, Vote Count: {vote_count}"; 
        }
    }
}