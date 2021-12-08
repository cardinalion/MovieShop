using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IGenreRepository _genreRepository;
        public FavoriteService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
    }
}