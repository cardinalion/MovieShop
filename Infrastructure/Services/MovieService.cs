﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private MovieRepository _movieRepository;
        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }

        public IEnumerable<MovieCardResponseModel> GetHighestGrossingMovies()
        {
            var movies = _movieRepository.Get30HighestGrossingMovies();
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
    }
}