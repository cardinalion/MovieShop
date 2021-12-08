using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class TrailerService : ITrailerService
    {
        private readonly IGenreRepository _genreRepository;
        public TrailerService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<TrailerResponseModel> GetTrailersByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
