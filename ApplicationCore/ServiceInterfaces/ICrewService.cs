using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICrewService
    {
        List<CrewModel> GetCrewsByMovieId(int movieId);
    }
}
