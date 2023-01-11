using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class Note : BaseEntity
    {
        public Guid TaskId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Task Task { get; set; }
    }
}
