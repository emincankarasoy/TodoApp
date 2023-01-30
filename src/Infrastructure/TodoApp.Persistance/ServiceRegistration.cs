using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Persistance.Contexts;

namespace TodoApp.Persistance
{
    public static class ServiceRegistration
    {
        public static void RegisterPersistanceServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<AppDBContext>(options => options.UseNpgsql(configuration.GetConnectionString("PostgreSQL")));
        }
    }
}
