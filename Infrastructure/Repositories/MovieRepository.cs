using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> Get30HighestGrossingMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetById(int id)
        {
            var movieDetails = await _dbContext.Movies.Include(m => m.Casts).ThenInclude(mc => mc.Cast)
                .Include(m => m.GenresOfMovie).ThenInclude(mg => mg.Genre).Include(m => m.Trailers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieDetails == null) return null;
            var rating = await _dbContext.Reviews.Where(m => m.MovieId == id).DefaultIfEmpty()
                .AverageAsync(r => r == null ? 0 : r.Rating);
            movieDetails.Rating = rating;
            return movieDetails;
        }
    }
}
