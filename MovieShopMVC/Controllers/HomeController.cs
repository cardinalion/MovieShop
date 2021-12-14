using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;
        public HomeController(IMovieService movieService, IGenreService genreService)
        {
            _movieService = movieService;
            _genreService = genreService;

        }

        public async Task<IActionResult> Index()
        {
            // THREE ways to pass data/model from Controller Action to View
            // 1. pass the models in View method
            // 2. viewbag
            // 3. viewdata
            var movieCards = await _movieService.GetHighestGrossingMovies();
            return View(movieCards);
        }

        public IActionResult Privacy()
        {
            //test
            var genres = _genreService.GetAllGenres();
            return View(genres);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}