using System.Linq.Expressions;

namespace Hardwhere_API.Interfaces
{
    public interface IRepository<TGeneric> where TGeneric : class
    {
        IEnumerable<TGeneric> GetAllComponents();
        TGeneric GetComponentsById(int id);
        void Create(TGeneric generic);

        //Toma una expresion que es una funcion que recibe un metodo generico y devuelve un array de objetos.
        IEnumerable<TGeneric> GetAllComponentsIncluding<TGeneric>(params Expression<Func<TGeneric, object>>[] includeComponents) where TGeneric : class;

    }
}
