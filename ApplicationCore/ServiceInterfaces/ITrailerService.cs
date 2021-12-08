using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITrailerService
    {
        List<TrailerModel> GetTrailersByMovieId(int movieId);
    }
}
