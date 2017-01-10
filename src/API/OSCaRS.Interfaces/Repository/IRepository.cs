using System.Linq;
using System.Threading.Tasks;

namespace OSCaRS.Interfaces.Repository
{
    public interface IRepository<T>
    {
        T Get<TKey>(TKey id);
        IQueryable<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
    }
}
