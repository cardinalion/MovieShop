using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IGenreRepository _genreRepository;
        public UserService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
    }
}
