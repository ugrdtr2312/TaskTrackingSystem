using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Task = System.Threading.Tasks.Task;

namespace DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity: BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> GetByIdAsyncAsTracking(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, Task<bool>> predicate);
        Task CreateAsync(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}