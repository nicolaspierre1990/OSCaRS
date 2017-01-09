using System.Linq;

namespace OSCaRS.Interfaces.Repository
{
    public interface IRepository<T>
    {
        T Get<TKey>(TKey id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
    }
}
