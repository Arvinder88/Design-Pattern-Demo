using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IRepository<TEntity> where TEntity :class
    {
        TEntity get(int Id);
        IEnumerable<TEntity> GetAll();

        int Insert(TEntity Entity);
        int InsertRange(IEnumerable<TEntity> Entities);

        int Remove(TEntity Entity);
        int RemoveRange(IEnumerable<TEntity> Entities);

        int Update(TEntity Entity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
       
    }
}
