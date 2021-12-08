using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MovieShopDbContext _dbContext;
        public Repository(MovieShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var entity =  _dbContext.Set<T>().Find(id);
            return entity;
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
