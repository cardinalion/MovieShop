using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public List<GenreModel> GetAllGenres()
        {
            var genres = _genreRepository.GetAll();
            var genreModel = new List<GenreModel>();
            foreach (var genre in genres)
            {
                genreModel.Add(new GenreModel { Id = genre.Id, Name = genre.Name });
            }
            return genreModel;
        }
    }
}
