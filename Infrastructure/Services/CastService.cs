using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly IGenreRepository _genreRepository;
        public CastService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<CastResponseModel> GetCastsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
