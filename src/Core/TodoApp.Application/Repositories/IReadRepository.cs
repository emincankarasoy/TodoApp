using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Application.Repositories
{
    public interface IReadRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity? Get(Guid id);

        TEntity? Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetList();

        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = ""
            );

        IEnumerable<TEntity> GetList(int pageSize = 10, 
            int pageIndex = 1,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Expression<Func<TEntity, bool>>? predicate = null
            );

        Task<TEntity?> GetAsync(Guid id);

        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetListAsync();

        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");

        Task<IEnumerable<TEntity>> GetListAsync(int pageSize = 10, int pageIndex = 1, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Expression<Func<TEntity, bool>>? predicate = null);
    }
}
