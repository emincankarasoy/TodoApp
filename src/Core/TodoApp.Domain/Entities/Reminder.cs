using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class Reminder : BaseEntity
    {
        public DateTime DueDate { get; set; }

        public Task Task { get; set; }
    }
}
