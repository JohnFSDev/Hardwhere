using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hardwhere_API.Repositories
{
    public class Repository<TGeneric> : IRepository<TGeneric> where TGeneric : class
    {
        private readonly HardwhereDbContext _dbContext; //Lee el contexto de la base de datos.
        public Repository(HardwhereDbContext context)
        {
            _dbContext = context;
        }
        public void Create(TGeneric generic)
        {
            _dbContext.Set<TGeneric>().Add(generic);
            _dbContext.SaveChanges();
        }

        public void Update(TGeneric generic)
        {
            _dbContext.Set<TGeneric>().Update(generic);
            _dbContext.SaveChanges();
        }


        public TGeneric GetComponentsById(int id)
        {
            var component = _dbContext.Set<TGeneric>().Find(id);
            return component;

        }

        public IEnumerable<TGeneric> GetAllComponents()
        {
            var allcomponents = _dbContext.Set<TGeneric>().ToList();
            return allcomponents;
        }

        public async Task<IEnumerable<TGeneric>> GetAllComponentsIncluding<TGeneric>(params Expression<Func<TGeneric, object>>[] includeComponents) where TGeneric : class
        {
            IQueryable<TGeneric> query = _dbContext.Set<TGeneric>();

            foreach (var item in includeComponents)
            {
                query = query.Include(item);
            }

            return await query.ToListAsync();
        }

        public TGeneric GetComponentsByIdIncluding<TGeneric>(Expression<Func<TGeneric, bool>> expression, params Expression<Func<TGeneric, object>>[] includeComponents) where TGeneric : class
        {
            IQueryable<TGeneric> query = _dbContext.Set<TGeneric>();
            if (expression != null)
            {
                query = query.Where(expression);    
            }
            foreach (var item in includeComponents)
            {
                query = query.Include(item);
            }

            return query.FirstOrDefault();
        }
    }
}
