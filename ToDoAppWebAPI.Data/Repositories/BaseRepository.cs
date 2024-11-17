using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ToDoAppWebAPI.Data.Interfaces;

namespace ToDoAppWebAPI.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ToDoDbContext toDoDbContext;
        protected readonly DbSet<TEntity> dbSet;

        public BaseRepository(ToDoDbContext toDoDbContext)
        {
            this.toDoDbContext = toDoDbContext;
            dbSet = toDoDbContext.Set<TEntity>();
        }

        public IList<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public TEntity Insert(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = dbSet.Add(entity);
            toDoDbContext.SaveChanges();
            return entityEntry.Entity;
        }
    }
}
