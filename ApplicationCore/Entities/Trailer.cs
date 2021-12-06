

namespace ApplicationCore.Entities
{
    public class Trailer
    {
        public int Id { get; set; }
        public string TrailerUrl { get; set; }
        public string name { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
