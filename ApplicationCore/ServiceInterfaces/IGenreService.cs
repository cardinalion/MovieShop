using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IGenreService
    {
        List<GenreModel> GetAllGenres();
    }
}
