using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Persistance.Contexts
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }
        
    }
}
