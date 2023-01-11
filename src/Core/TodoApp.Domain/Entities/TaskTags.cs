using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Entities
{
    public class TaskTags
    {
        public Guid TaskId { get; set; }

        public Guid TagId { get; set; }
    }
}
