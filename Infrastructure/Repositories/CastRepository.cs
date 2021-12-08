using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CastRepository : Repository<Cast>, ICastRepository
    {
        public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
