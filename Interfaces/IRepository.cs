namespace Hardwhere_API.Interfaces
{
    public interface IRepository<TGeneric> where TGeneric : class
    {
        void Create(TGeneric generic);
        TGeneric GetComponentsById(int id);

        IEnumerable<TGeneric> GetAllComponents();

    }
}
