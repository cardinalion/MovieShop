using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        List<CastResponseModel> GetCastsByMovieId(int movieId);
    }
}
