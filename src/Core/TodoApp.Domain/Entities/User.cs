using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string SecurityStamp { get; set; }
    }
}
