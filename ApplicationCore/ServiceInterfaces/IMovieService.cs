using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieCardResponseModel> GetHighestGrossingMovies();

        MovieDetailsResponseModel GetMovieDetailsById(int id);
    }
}
