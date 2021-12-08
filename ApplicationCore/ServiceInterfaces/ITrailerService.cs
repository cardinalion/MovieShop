using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITrailerService
    {
        List<TrailerResponseModel> GetTrailersByMovieId(int movieId);
    }
}
