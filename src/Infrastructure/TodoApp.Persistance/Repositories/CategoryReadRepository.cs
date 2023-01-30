using Microsoft.EntityFrameworkCore;
using TodoApp.Application.Repositories;
using TodoApp.Domain.Entities;
using TodoApp.Persistance.Repositories.Common;

namespace TodoApp.Persistance.Repositories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(DbContext context) : base(context)
        {
        }
    }
}
