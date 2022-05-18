namespace DicModels.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
    
    Task DeleteAsync(int id);
    
    Task FindAsync(int id);
    
    // Task<ICollection<IEntity>> GetAllAsync();

    Task UpdateAsync(TEntity entity);
}
