using Microsoft.EntityFrameworkCore;
using OSCaRS.Interfaces.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace OSCaRS.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> DbSet;

        public Repository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Save();
        }

        public T Get<TKey>(TKey id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public async Task Update(T entity)
        {
            await Save();
        }

        private async Task Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}
