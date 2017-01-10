using Microsoft.EntityFrameworkCore;
using OSCaRS.Interfaces.Repository;
using System.Linq;

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

        public async void Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);

            Save();
        }

        public T Get<TKey>(TKey id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public void Update(T entity)
        {
            Save();
        }

        private async void Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}
