using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;
        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> RegisterUser(UserRegisterRequestModel model)
        {
            var dbUser = await _userRepository.GetUserByEmail(model.Email);
            if (dbUser != null)
            {
                throw new Exception("Email already exists");
            }
            string salt = GenerateSalt();
            var hashedPassword = GetHashedPassword(model.Password, salt);
            var user = new User
            {
                Email = model.Email,
                HashedPassword = hashedPassword,
                Salt = salt,
                DateOfBirth = model.DateOfBirth,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var createdUser = await _userRepository.Add(user);
            return createdUser.Id;
        }

        public async Task<UserLoginResponseModel> ValidateUser(LoginRequestModel model)
        {
            var user = await _userRepository.GetUserByEmail(model.Email);
            if (user == null) return null;
            var hashedPassword = GetHashedPassword(model.Password, user.Salt);
            if (hashedPassword != user.HashedPassword)
            {
                return null;
            }
            var userLoginResponseModel = new UserLoginResponseModel
            {
                Id = user.Id,
                Email = model.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth
            };
            return userLoginResponseModel;
        }

        private string GenerateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }

        private string GetHashedPassword(string password, string salt)
        {
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                                                    password: password,
                                                                    salt: Convert.FromBase64String(salt),
                                                                    prf: KeyDerivationPrf.HMACSHA512,
                                                                    iterationCount: 10000,
                                                                    numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
