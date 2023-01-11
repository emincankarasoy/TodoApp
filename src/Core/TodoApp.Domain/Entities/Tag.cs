using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public Tag()
        {
            Tasks = new HashSet<Task>();
        }
        
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
