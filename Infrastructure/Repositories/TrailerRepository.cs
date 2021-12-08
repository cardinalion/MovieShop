using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TrailerRepository : Repository<Trailer>, ITrailerRepository
    {
        public TrailerRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}

