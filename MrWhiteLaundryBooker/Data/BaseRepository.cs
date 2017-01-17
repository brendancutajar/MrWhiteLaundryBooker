using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MrWhiteLaundryBooker.Data
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        private readonly LaundryBookerContext _context;

        public BaseRepository(LaundryBookerContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Search(params Expression<Func<TEntity, bool>>[] predicates)
        {
            var query = _context.Set<TEntity>().AsQueryable();

            foreach (var predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query;
        }
    }
}