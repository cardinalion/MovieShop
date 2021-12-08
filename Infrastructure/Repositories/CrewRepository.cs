using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CrewRepository : Repository<Crew>, ICrewRepository
    {
        public CrewRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}

