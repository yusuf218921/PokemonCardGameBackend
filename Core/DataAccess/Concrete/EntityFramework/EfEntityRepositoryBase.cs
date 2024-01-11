using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext: DbContext
    {
        private TContext _context;
        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

        public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter, bool trackchanges) =>
           !trackchanges ? _context.Set<TEntity>().Where(filter) :
               _context.Set<TEntity>().Where(filter).AsNoTracking();

        public IQueryable<TEntity> FindAll(bool trackchanges)
            => !trackchanges ? _context.Set<TEntity>()
            : _context.Set<TEntity>().AsNoTracking();

        public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);
    }
}
