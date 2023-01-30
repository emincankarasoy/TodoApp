using TodoApp.Application.Repositories.Common;
using TodoApp.Domain.Entities;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Application.Repositories
{
    public interface ICategoryWriteRepository : IWriteRepository<Category>
    {
    }
}
