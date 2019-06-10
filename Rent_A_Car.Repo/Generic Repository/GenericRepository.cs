using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Repo
{
    public class GenericRepository<TEntity> : IGenericRepository<> where TEntity : class
    {
        protected readonly DbContext Context;

        
        public GenericRepository(DbContext context)
        {
            Context = context;

        }
        public void Add(TEntity entity)
        {
            
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
           
        }

        public TEntity Get(int id)
        {
            
        }

        public IEnumerable<TEntity> GetAll()
        {
            
        }

        public void Remove(TEntity entity)
        {
           
        }
    }
}
