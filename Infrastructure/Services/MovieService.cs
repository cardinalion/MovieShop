using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<MovieCardResponseModel>> GetHighestGrossingMovies()
        {
            var movies = await _movieRepository.Get30HighestGrossingMovies();
            var movieCards = new List<MovieCardResponseModel>();
            foreach(var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }
            return movieCards;
        }

        public async Task<MovieDetailsResponseModel> GetMovieDetailsById(int id)
        {
            var movie = await _movieRepository.GetById(id);
            var movieDetails = new MovieDetailsResponseModel
            {
                Id = id,
                PosterUrl = movie.PosterUrl,
                Title = movie.Title,
                OriginalLanguage = movie.OriginalLanguage,
                Overview = movie.Overview,
                Rating = movie.Rating,
                Tagline = movie.Tagline,
                RunTime = movie.RunTime,
                BackdropUrl = movie.BackdropUrl,
                TmdbUrl = movie.TmdbUrl,
                ImdbUrl = movie.ImdbUrl,
                Budget = movie.Budget,
                Revenue = movie.Revenue,
                ReleaseDate = movie.ReleaseDate,
                Price = movie.Price
            };
            foreach (var trailer in movie.Trailers)
            {
                movieDetails.Trailers.Add(new TrailerResponseModel
                {
                    Id = trailer.Id,
                    Name = trailer.Name,
                    TrailerUrl = trailer.TrailerUrl,
                    MovieId = trailer.MovieId
                });
            }
            foreach (var genre in movie.GenresOfMovie)
            {
                movieDetails.Genres.Add(new GenreModel
                {
                    Id = genre.GenreId,
                    Name = genre.Genre.Name
                });
            }
            foreach (var cast in movie.Casts)
            {
                movieDetails.Casts.Add(new CastResponseModel
                {
                    Id = cast.CastId,
                    Name = cast.Cast.Name,
                    Character = cast.Character,
                    ProfilePath = cast.Cast.ProfilePath
                });
            }
            return movieDetails;
        }
    }
}
