
namespace RoleBase.Domain.Interfaces.Reporsitories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllNoTracking();

        Task<TEntity?> GetByIdAsync(Guid id);

        void Update(TEntity entity);

        Task<bool> ExistsAsync(Guid id);
        public void Remove(TEntity entity, bool hardDelete = false);
        void RemoveRange(IEnumerable<TEntity> entities, bool hardDelete = false);
    }
}
