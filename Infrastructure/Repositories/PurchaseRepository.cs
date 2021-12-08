using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class PurchaseRepository : Repository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
