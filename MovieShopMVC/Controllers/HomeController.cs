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
        private IMovieService _movieService;
        public HomeController(IMovieService movieService) // constructor dependency injection
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            // THREE ways to pass data/model from Controller Action to View
            // 1. pass the models in View method
            // 2. viewbag
            // 3. viewdata
            var movieCards = _movieService.GetHighestGrossingMovies();
            return View(movieCards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}