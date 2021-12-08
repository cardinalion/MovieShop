using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class CrewService : ICrewService
    {
        private readonly IGenreRepository _genreRepository;
        public CrewService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<CrewModel> GetCrewsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
