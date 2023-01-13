using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;
using TodoApp.Domain.Enums;

namespace TodoApp.Domain.Entities
{
    public class Task : BaseEntity
    {
        public Task()
        {
            Notes = new HashSet<Note>();    
        }

        public Guid CategoryId { get; set; }

        public Guid BaseTaskId { get; set; } = Guid.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Status Status { get; set; }

        public Priority Priority { get; set; }

        public Category Category { get; set; }

        public Reminder Reminder { get; set; }

        public Location Location { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
