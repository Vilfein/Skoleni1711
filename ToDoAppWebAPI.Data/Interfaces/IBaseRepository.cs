namespace ToDoAppWebAPI.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity Insert(TEntity entity);
    }

}
