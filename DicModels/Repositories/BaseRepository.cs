using Microsoft.EntityFrameworkCore;

namespace DicModels.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DbContext Context;

    public BaseRepository(DbContext db)
    {
        this.Context = db;
    }

    public async Task FindAsync(int id)
    {
        
    }

    public async Task AddAsync(TEntity entity)
    {
        
    }
    public async Task DeleteAsync(int id)
    {
        
    }
    public async Task UpdateAsync(TEntity entity)
    {
        
    }
}