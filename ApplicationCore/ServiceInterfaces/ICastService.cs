using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        List<CastModel> GetCastsByMovieId(int movieId);
    }
}
