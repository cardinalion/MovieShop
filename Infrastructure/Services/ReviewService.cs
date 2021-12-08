using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IGenreRepository _genreRepository;
        public ReviewService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<ReviewModel> GetReviewsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
