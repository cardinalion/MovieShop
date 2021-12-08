using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class FavoriteRepository : Repository<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
