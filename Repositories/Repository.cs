using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public TGeneric GetComponentsById(int id) 
        {
            var component =  _dbContext.Set<TGeneric>().Find(id);
            return component;
        }
    }
}
