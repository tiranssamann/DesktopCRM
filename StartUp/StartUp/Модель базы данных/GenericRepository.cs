using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Core.Objects;

namespace StartUp.Модель_базы_данных
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbset;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public void Create(TEntity item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }

        public TEntity FindById(int id)
        {
            return _dbset.Find(id);
        }


        public IEnumerable<TEntity> Get()
        {
            return _dbset.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbset.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(TEntity item)
        {
            _dbset.Remove(item);
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }
        public IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbset.AsNoTracking();
            return includeProperties.Aggregate(query, (current, includeProperty) => (current.Include(includeProperty)));
        }
    }
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);

        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
