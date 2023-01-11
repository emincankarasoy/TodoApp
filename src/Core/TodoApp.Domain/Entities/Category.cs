using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
