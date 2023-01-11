using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public Guid OwnerUserId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public User OwnerUser { get; set; }
    }
}
