using HektorAPI.Core.Entities.Base;

namespace HektorAPI.Core.Entities
{
    public class Movie : Entity
    {
        public Movie(string movieName, string directorName, string releaseYear)
        {
            MovieName = movieName;
            DirectorName = directorName;
            ReleaseYear = releaseYear;
        }

        public string MovieName { get; private set; }
        public string DirectorName { get; private set; }
        public string ReleaseYear { get; private set; }
        
        
        
    }
}