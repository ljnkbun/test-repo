using Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DBReadDbContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("DBReadConnection")!)
                    .EnableSensitiveDataLogging()
            );

            services.AddDbContext<DBWriteDbContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("DBWriteConnection")!)
                    .EnableSensitiveDataLogging()
            );


        }
    }
}
