using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Application.Repositories
{
    public interface IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entity);

        void Update(TEntity entity);
        
        void Delete(TEntity entity);

        Task InsertAsync(TEntity entity);

        Task InsertRangeAsync(IEnumerable<TEntity> entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
