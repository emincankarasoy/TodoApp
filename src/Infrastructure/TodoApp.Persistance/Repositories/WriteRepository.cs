using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Repositories;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Persistance.Repositories
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public WriteRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Insert(TEntity entity) => _dbSet.Add(entity);

        public void InsertRange(IEnumerable<TEntity> entity) => _dbSet.AddRange(entity);

        public void Update(TEntity entity) => _dbSet.Update(entity);

        public void Delete(TEntity entity) => _dbSet.Remove(entity);

        public void Save() => _context.SaveChanges();

        public async Task InsertAsync(TEntity entity) => await _dbSet.AddAsync(entity);

        public async Task InsertRangeAsync(IEnumerable<TEntity> entity) => await _dbSet.AddRangeAsync(entity);

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
