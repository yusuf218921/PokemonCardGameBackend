using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T: class, IEntity, new()
    {
        public void Add(T entity);
        public void Delete(int id);
        public void Update(T entity);
        public T Get(Expression<Func<T, bool>> filter);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);

    }
}
