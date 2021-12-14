using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> EditUserProfile(UserDetailsModel userDetailsModel)
        {
            var user = await _userRepository.GetById(userDetailsModel.Id);
            // user doesn't exist
            if (user == null) return false;
            // invalid values
            if (userDetailsModel.FirstName == null ||
                    userDetailsModel.LastName == null || userDetailsModel.Email == null ||
                    userDetailsModel.Email != user.Email)
            {
                return false;
            }
            // update
            user.FirstName = userDetailsModel.FirstName;
            user.LastName = userDetailsModel.LastName;
            user.PhoneNumber = userDetailsModel.PhoneNumber;
            user.ProfilePictureUrl = userDetailsModel.ProfilePictureUrl;
            user.DateOfBirth = userDetailsModel.DateOfBirth;
            await _userRepository.Update(user);
            return true;
        }

        public async Task<UserDetailsModel> GetUserDetails(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null) return null;
            var userDetailsModel = new UserDetailsModel{
                Id = id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                ProfilePictureUrl = user.ProfilePictureUrl,
                DateOfBirth = user.DateOfBirth
            };
            return userDetailsModel;
        }

        public async Task<List<MovieCardResponseModel>> GetUserFavoritedMovies(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null) return null;
            var favoriteMovieList = new List<MovieCardResponseModel>();
            foreach (Favorite favorite in user.Favorites)
            {
                favoriteMovieList.Add(new MovieCardResponseModel
                {
                    Id = favorite.MovieId,
                    Title = favorite.Movie.Title,
                    PosterUrl = favorite.Movie.PosterUrl
                });
            }
            return favoriteMovieList;
        }

        public async Task<List<MovieCardResponseModel>> GetUserPurchasedMovies(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null) return null;
            var purchasedMovieList = new List<MovieCardResponseModel>();
            foreach (Purchase purchase in user.Purchases)
            {
                purchasedMovieList.Add(new MovieCardResponseModel
                {
                    Id = purchase.MovieId,
                    Title = purchase.Movie.Title,
                    PosterUrl = purchase.Movie.PosterUrl
                });
            }
            return purchasedMovieList;
        }
    }
}
