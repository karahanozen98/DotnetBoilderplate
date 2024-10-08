using System.Linq.Expressions;
using DotnetBoilerplate.Domain.Common;
using DotnetBoilerplate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotnetBoilerplate.Infrastructure.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IList<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(x => x.Id == new Guid()).ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task SaveChangesAsync()
        {
            var addedEntities = this._context.ChangeTracker
                .Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Added);

            foreach (var item in addedEntities)
            {
                item.Entity.SetCreatedAt();
            }

            var modifiedEntities = this._context.ChangeTracker
                .Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Modified);

            foreach (var item in modifiedEntities)
            {
                item.Entity.SetUpdatedAt();
            }

            await this._context.SaveChangesAsync();
        }
    }
}