using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IReviewService
    {
        List<ReviewModel> GetReviewsByMovieId(int movieId);
    }
}
