using Microsoft.EntityFrameworkCore;
using RoleBase.Domain.Interfaces.Reporsitories;
using RoleBase.Infrastructure.Data;
using System.Collections.Generic;

namespace RoleBase.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RoleBaseDbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(RoleBaseDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }
        
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> GetAllNoTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public Task<TEntity?> GetByIdAsync(Guid id)
        {
            return _dbSet.FindAsync(id).AsTask();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public Task<bool> ExistsAsync(Guid id)
        {
            return _dbSet.FindAsync(id).AsTask().ContinueWith(task => task.Result != null);
        }

        public void Remove(TEntity entity, bool hardDelete = false)
        {
            if (hardDelete) 
            {
                _dbSet.Remove(entity);
            }
            else
            {
                //entity.D
            }
        }

        public void RemoveRange(IEnumerable<TEntity> entities, bool hardDelete = false)
        {
            if (hardDelete)
            {
                _dbSet.RemoveRange(entities);
                return;
            }

            foreach (var entity in entities)
            {
                //entity.Delete();
            }
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
