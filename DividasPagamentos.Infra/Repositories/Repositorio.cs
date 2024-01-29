using DividasPagamentos.Infra.Context;
using DividasPagamentos.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DividasPagamentos.Infra.Repositories
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DatabaseContext _dbContext;

        public DbSet<TEntity> DbSet
        {
            get
            {
                return _dbContext.Set<TEntity>();
            }
        }

        public Repositorio(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
