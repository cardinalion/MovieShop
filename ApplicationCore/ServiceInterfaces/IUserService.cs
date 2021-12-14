using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<List<MovieCardResponseModel>> GetUserPurchasedMovies(int id);
        Task<List<MovieCardResponseModel>> GetUserFavoritedMovies(int id);
        Task<UserDetailsModel> GetUserDetails(int id);
        Task<bool> EditUserProfile(UserDetailsModel userDetailsModel);
    }
}
