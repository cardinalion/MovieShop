using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IGenreRepository _genreRepository;
        public PurchaseService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public List<PurchaseModel> GetPurchasesByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}