using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepositories;
using DataModels.DataObjects;
using DataModels;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class Repository<TEnitity> : IRepository<TEnitity> where TEnitity:class
    {
        public readonly DbContext _Context;

        private DbSet<TEnitity> _Dbset;

        public Repository(StoreContext context)
        {
            _Context = context;
            _Dbset = _Context.Set<TEnitity>();
        }

        public TEnitity get(int Id)
        {
            return _Dbset.Find(Id);
        }

        public IEnumerable<TEnitity> GetAll()
        {
            return _Dbset.ToList();
        }

        public int Insert(TEnitity Entity)
        {
            _Dbset.Add(Entity);
            return _Context.SaveChanges();

        }

        public int InsertRange(IEnumerable<TEnitity> Entities)
        {
            _Dbset.AddRange(Entities);
            return _Context.SaveChanges();
        }

        public int Remove(TEnitity Entity)
        {
             _Dbset.Remove(Entity);
             return _Context.SaveChanges();
        }

        public int RemoveRange(IEnumerable<TEnitity> Entities)
        {
            _Dbset.RemoveRange(Entities);
            return _Context.SaveChanges();
        }

        public int Update(TEnitity Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
            return _Context.SaveChanges();
        }

        public IEnumerable<TEnitity> Find(System.Linq.Expressions.Expression<Func<TEnitity, bool>> predicate)
        {
            return _Dbset.Where(predicate);
        }
        public IEnumerable<TEnitity> Where(System.Linq.Expressions.Expression<Func<TEnitity, bool>> predicate)
        {
            return _Dbset.Where(predicate);
        }

        public TEnitity SingleOrDefault(System.Linq.Expressions.Expression<Func<TEnitity, bool>> predicate)
        {
            return _Dbset.SingleOrDefault(predicate);
        }

        public TEnitity FirstOrDefault(System.Linq.Expressions.Expression<Func<TEnitity, bool>> predicate)
        {
            return _Dbset.FirstOrDefault(predicate);
        }
    }
}
