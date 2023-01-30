using Microsoft.EntityFrameworkCore;
using TodoApp.Application.Repositories;
using TodoApp.Domain.Entities;
using TodoApp.Persistance.Repositories.Common;

namespace TodoApp.Persistance.Repositories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(DbContext context) : base(context)
        {
        }
    }
}
