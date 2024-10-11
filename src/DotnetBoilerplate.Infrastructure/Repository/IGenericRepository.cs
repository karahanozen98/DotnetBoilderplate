using System.Linq.Expressions;

namespace DotnetBoilerplate.Infrastructure.Repository
{
    public interface IGenericRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        public Task<TEntity?> GetByIdAsync(Guid id);
        public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        public Task<IList<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public Task DeleteAsync(Guid id);
        Task SaveChangesAsync();
    }
}