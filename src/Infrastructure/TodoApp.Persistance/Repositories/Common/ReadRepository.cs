using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Repositories.Common;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Persistance.Repositories.Common
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public ReadRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public TEntity? Get(Guid id) => _dbSet.FirstOrDefault(x => x.Id == id);

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate) => _dbSet.FirstOrDefault(predicate);

        public IEnumerable<TEntity> GetList() => _dbSet.AsNoTrackingWithIdentityResolution().ToList();

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            query = this.GenerateQueryable(predicate: predicate, orderBy: orderBy, includeProperties: includeProperties);

            return query.AsNoTrackingWithIdentityResolution().ToList();
        }

        public IEnumerable<TEntity> GetList(int pageSize = 10, int pageIndex = 1, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Expression<Func<TEntity, bool>>? predicate = null)
        {
            IQueryable<TEntity> query = _dbSet;

            query = this.GenerateQueryable(pageSize: pageSize, pageIndex: pageIndex, orderBy: orderBy, predicate: predicate);

            return query.AsNoTrackingWithIdentityResolution().ToList();
        }

        public async Task<TEntity?> GetAsync(Guid id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate) => await _dbSet.FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<TEntity>> GetListAsync() => await _dbSet.AsNoTrackingWithIdentityResolution().ToListAsync();

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            query = this.GenerateQueryable(predicate: predicate, orderBy: orderBy, includeProperties: includeProperties);

            return await query.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(int pageSize = 10, int pageIndex = 1, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Expression<Func<TEntity, bool>>? predicate = null)
        {
            IQueryable<TEntity> query = _dbSet;

            query = this.GenerateQueryable(pageSize: pageSize, pageIndex: pageIndex, orderBy: orderBy, predicate: predicate);

            return await query.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

        private IQueryable<TEntity> GenerateQueryable(Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "",
            int pageSize = 0,
            int pageIndex = 0)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (pageIndex != 0 && pageSize != 0)
            {
                query = query.Skip((pageSize - 1) * pageSize).Take(pageSize);
            }

            return query;
        }
    }
}
